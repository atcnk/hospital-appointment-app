﻿namespace Application.Features.PatientReports.Commands.Delete
{
    public class DeletePatientReportResponse
    {
        public int Id { get; set; }
        public string Detail { get; set; } = "Deletion Successful!";
    }
}
