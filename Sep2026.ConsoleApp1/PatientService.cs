using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep2026.ConsoleApp1
{
    public class PatientService
    {
        public static List<PatientDto> Patients = new List<PatientDto>();
        public void AddPatient(string patientNo, string patientName, int patientAge)
        {
            int maxId = Patients.Count==0 ? 0 : Patients.Max(x => x.Id);
            PatientDto patient = new PatientDto
            {
                Id = maxId + 1,
                PatientNo = patientNo,
                Name = patientName,
                Age = patientAge
            };
            Patients.Add(patient);
        }
        public void ShowPatients()
        {
            foreach (var patient in Patients)
            {
                Console.WriteLine($"Id: {patient.Id}, PatientNo: {patient.PatientNo}, Name: {patient.Name}, Age: {patient.Age}");
            }
 

        }
    }
}
