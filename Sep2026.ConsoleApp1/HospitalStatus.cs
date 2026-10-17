using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep2026.ConsoleApp1
{
    public class HospitalStatus 
    {
        public static List<HospitalStatusDto> HospitalStatuses = new List<HospitalStatusDto>();
        public void AddHospitalStatus(string patientNo, string diseaseName, int roomNumber)
        {
            var patient = PatientService.Patients.Where(x => x.PatientNo == patientNo).FirstOrDefault();
            if(patient == null)
            {
                Console.WriteLine($"Patient with number {patientNo} not found.");
                return;
            }

            int maxId = HospitalStatuses.Count == 0 ? 0 : HospitalStatuses.Max(x => x.HospitalId);

            

            HospitalStatusDto hospitalStatus = new HospitalStatusDto
            {
                HospitalId = maxId + 1,
                PatientId = patient.Id,
                DiseaseName = diseaseName,
                RoomNumber = roomNumber
            };
            HospitalStatuses.Add(hospitalStatus);

            foreach (var item in HospitalStatuses)
            {
                Console.WriteLine($"Patient : {item.PatientId} with disease {item.DiseaseName} in room {item.RoomNumber}.");
            }
        }
        public void FindPatient(string patientNo)
        {
            var patient = PatientService.Patients.Where(x => x.PatientNo == patientNo).FirstOrDefault();
            if (patient == null)
            {
                Console.WriteLine($"Patient with number {patientNo} not found.");
                return;
            }

            var status = HospitalStatuses.Where(x => x.PatientId == patient.Id).FirstOrDefault();
            if (status == null)
            {
                Console.WriteLine($"{patient.Name} is not at the hospital.");
                return;
            }

            Console.WriteLine($"{patient.Name} is at the hospital.");
            Console.WriteLine($"Disease : {status.DiseaseName}");
            Console.WriteLine($"Room : {status.RoomNumber}");
        }
    }
}
