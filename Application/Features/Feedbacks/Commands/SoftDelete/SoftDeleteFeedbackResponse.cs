﻿namespace Application.Features.Feedbacks.Commands.SoftDelete
{
    public class SoftDeleteFeedbackResponse
    {
        public int Id { get; set; }
        public string Detail { get; set; } = "Deletion Successful!";
    }
}
