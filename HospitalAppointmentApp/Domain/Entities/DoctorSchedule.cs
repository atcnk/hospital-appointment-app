using Core.Persistence;

namespace Domain.Entities
{
    public class DoctorSchedule : Entity
    {
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime AvailableDate { get; set; }
        public DateTime StartTime { get; set; } 
        public DateTime EndTime { get; set; } 
    }
}
