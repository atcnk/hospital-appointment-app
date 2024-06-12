using Core.Persistence;
using Domain.Enums;

namespace Domain.Entities
{
    public class Appointment : Entity
    {
        public AppointmentStatus AppointmentStatus { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
