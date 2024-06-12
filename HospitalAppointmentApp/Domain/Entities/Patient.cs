using Domain.Enums;

namespace Domain.Entities
{
    public class Patient : User
    {
        public BloodType BloodType { get; set; }
        public InsuranceType InsuranceType { get; set; }
        public string NationalId { get; set; }
        public string HealthHistory { get; set; }
        public string Allergies { get; set; }
        public string CurrentMedications { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactPhoneNumber { get; set; }
        public string EmergencyContactRelationship { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<PatientReport> PatientReports { get; set; }
    }
}