using Sep2026.ConsoleApp1;
Console.WriteLine("The Best Hospital");

Start:
Console.WriteLine();
Console.WriteLine("==============================");
Console.WriteLine("        MAIN MENU");
Console.WriteLine("==============================");
Console.WriteLine("1. Add Patient");
Console.WriteLine("2. Add Hospital Status");
Console.WriteLine("3. Show Patients");
Console.WriteLine("4. Find Patient");
Console.WriteLine("5. Exit");
Console.WriteLine("------------------------------");

Console.Write("Enter your choice: (1-5) ");
String choice = Console.ReadLine();
Console.WriteLine();

PatientService patientService = new PatientService();
HospitalStatus hospitalStatus = new HospitalStatus();

switch (choice)
{
    case "1":
        {
            Console.WriteLine("----- Add Patient -----");
            Console.Write("Enter patient no: ");
            String no = Console.ReadLine();

            Console.Write("Enter patient name: ");
            String name = Console.ReadLine();

            Console.Write("Enter patient age: ");
            String ageInput = Console.ReadLine();
            int age = int.Parse(ageInput);

            patientService.AddPatient(no, name, age);
            patientService.ShowPatients();
            break;
        }
    case "2":
        {
            Console.WriteLine("----- Add Hospital Status -----");
            Console.Write("Enter patient no: ");
            String no = Console.ReadLine();

            Console.Write("Enter disease name: ");
            String diseaseName = Console.ReadLine();

            Console.Write("Enter room number: ");
            int roomNumber = int.Parse(Console.ReadLine());

            hospitalStatus.AddHospitalStatus(no, diseaseName, roomNumber);
            break;
        }
    case "3":
        Console.WriteLine("----- Patient List -----");
        patientService.ShowPatients();
        break;
    case "4":
        {
            Console.WriteLine("----- Find Patient -----");
            Console.Write("Enter patient no: ");
            String no = Console.ReadLine();

            hospitalStatus.FindPatient(no);
            break;
        }
    case "5":
        Console.WriteLine("Exiting...");
        goto End;
    default:
        Console.WriteLine("Invalid choice.");
        break;
}

goto Start;
End:
Console.WriteLine("Thank you for using The Best Hospital system.");