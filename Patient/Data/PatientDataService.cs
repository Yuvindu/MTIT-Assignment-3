namespace Patient.Data
{
    public class PatientDataService
    {
        public static List<Models.Patient> Patients = new List<Models.Patient>()
        {
            new Models.Patient { Id = 1, Name = "John wick", Address = "12/A fazer St, Malabe", Age = 43, Blood_Group = "A+", Mobile = 0758286910 },
            new Models.Patient { Id = 2, Name = "Mary perera", Address = "45 Second Ave, Malabe", Age = 21, Blood_Group = "B+", Mobile = 0772638567 },
            new Models.Patient { Id = 3, Name = "Tom holland", Address = "78 salmal uyana, Malabe", Age = 28, Blood_Group = "O", Mobile = 0708666231 },
            new Models.Patient { Id = 4, Name = "Kate sirera", Address = "32 Fourth lane, Malabe", Age = 64, Blood_Group = "A-", Mobile = 0752637575 },
            new Models.Patient { Id = 5, Name = "Mike tyson", Address = "65/12B kahanthota Road, Malabe", Age = 55, Blood_Group = "O+", Mobile = 0761168244 }
        };
    }
}
