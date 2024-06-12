using Core.Persistence;

namespace Domain.Entities
{
    public class Feedback : Entity
    {
        public string FeedbackTitle { get; set; }
        public string FeedbackDescription { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
