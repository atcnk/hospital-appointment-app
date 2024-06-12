namespace Domain.Entities
{
    public class Doctor : User
    {
        public string SpecialistLevel { get; set; }
        public string Qualifications { get; set; }
        public int YearsOfExperience { get; set; }
        public string Biography { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<DoctorSchedule> DoctorSchedules { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<PatientReport> PatientReports { get; set; }
    }
}
