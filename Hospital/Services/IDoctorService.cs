namespace Doctor.Services
{
    public interface IDoctorService
    {
        List<Models.Doctor> GetDoctors();
        Models.Doctor? GetDoctor(int id);
        Models.Doctor? AddDoctor(Models.Doctor student);
        Models.Doctor? UpdateDoctor(Models.Doctor student);
        bool? DeleteDoctor(int id);
    }
}
