﻿namespace Application.Features.Appointments.Commands.Delete
{
    public class DeleteAppointmentResponse
	{
        public int Id { get; set; }
        public string Detail { get; set; } = "Deletion Successful!";
    }
}
