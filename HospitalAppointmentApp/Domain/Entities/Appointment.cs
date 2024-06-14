using Core.Persistence;
using Domain.Enums;

namespace Domain.Entities
{
    public class Appointment : Entity<int>
    {
        public AppointmentStatus Status { get; set; }
        public DateTime Date { get; set; }
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
        public int PatientReportId { get; set; }
        public virtual PatientReport PatientReport { get; set; }
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
