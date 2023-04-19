using Patient.Data;
using Patient.Models;

namespace Patient.Services
{
    public class PatientService : IPatientService
    {
        public List<Models.Patient> GetPatients()
        {
            return PatientDataService.Patients;
        }

        public Models.Patient? GetPatient(int id)
        {
            return PatientDataService.Patients.FirstOrDefault(x => x.Id == id);
        }

        public Models.Patient? AddPatient(Models.Patient patient)
        {
            PatientDataService.Patients.Add(patient);
            return patient;
        }

        public Models.Patient? UpdatePatient(Models.Patient patient)
        {
            Models.Patient selectedPatient = PatientDataService.Patients.FirstOrDefault(x => x.Id == patient.Id);
            if (selectedPatient != null)
            {
                selectedPatient.Mobile = patient.Mobile;
                selectedPatient.Blood_Group = patient.Blood_Group;
                selectedPatient.Address = patient.Address;
                selectedPatient.Age = patient.Age;
                selectedPatient.Name = patient.Name;
                return selectedPatient;
            }

            return selectedPatient;
        }

        public bool? DeletePatient(int id)
        {
            Models.Patient selectedPatient = PatientDataService.Patients.FirstOrDefault(x => x.Id == id);
            if (selectedPatient != null)
            {
                PatientDataService.Patients.Remove(selectedPatient);
                return true;
            }
            return false;
        }
    }
}
