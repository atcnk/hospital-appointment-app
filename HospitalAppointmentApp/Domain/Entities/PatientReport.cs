using Core.Persistence;

namespace Domain.Entities
{
    public class PatientReport : Entity
    {
        public string Title { get; set; }
        public string Details { get; set; }
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
        public int AppointmentId { get; set; }
        public virtual Appointment Appointment { get; set; }
    }
}