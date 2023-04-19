namespace Doctor.DoctorInfo
{
    public class DoctorDataService
    {
        public static List<Models.Doctor> Doctors = new List<Models.Doctor>()
        {
            new Models.Doctor{ Id = 1, Name = "Gregory House", Age = 45, Address = "123 Main St", Specialization = "Neuro Surgeon", Contact_No = 0714896649},
            new Models.Doctor{ Id = 2, Name = "Stephen Strange", Age = 43, Address = "134, Wilde Rd", Specialization = "Dermatologist", Contact_No = 0714893542},
            new Models.Doctor{ Id = 3, Name = "John Watson", Age = 38, Address = "221/B, Baker St", Specialization = "ENT Surgen", Contact_No = 0714896649},
            new Models.Doctor{ Id = 4, Name = "Lisa Cuddy", Age = 35, Address = "331, Riker St", Specialization = "Pediatrician", Contact_No = 0714892463},
            new Models.Doctor{ Id = 5, Name = "Howland Reed", Age = 41, Address = "112, Cross Av", Specialization = "Pathologist", Contact_No = 0714896649}
        };
    }
}
