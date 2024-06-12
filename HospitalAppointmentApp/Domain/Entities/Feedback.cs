﻿using Core.Persistence;

namespace Domain.Entities
{
    public class Feedback : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
