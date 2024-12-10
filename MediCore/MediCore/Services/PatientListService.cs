using MediPlanner.Class;

namespace MediCore.Services
{
    public class PatientListService
    {
        public List<Patient> patients { get; set; }

        public PatientListService()
        {
            patients = new List<Patient>();
        }
    }
}
