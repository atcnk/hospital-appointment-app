﻿using Domain.Enums;

namespace Application.Features.Appointments.Commands.Create
{
    public class CreateAppointmentResponse
    {
		public int Id { get; set; }
		public int PatientId { get; set; }
		public int DoctorAvailabilityId { get; set; }
		public AppointmentStatus Status { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
