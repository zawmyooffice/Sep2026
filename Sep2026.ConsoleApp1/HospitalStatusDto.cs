using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep2026.ConsoleApp1
{
    public class HospitalStatusDto    
    {
        public int HospitalId { get; set; }
        public int PatientId { get; set; }
        public string DiseaseName { get; set; }
        public int RoomNumber { get; set; }
    }
}
