using MediatR;

namespace Application.Features.DoctorSchedules.Commands.Create
{
    public class CreateDoctorScheduleCommand : IRequest<CreateDoctorScheduleResponse>
    {
        public DateTime AvailableDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int DoctorId { get; set; }
    }
}
