using MediatR;

namespace Application.Features.DoctorSchedules.Commands.Delete
{
    public class DeleteDoctorScheduleCommand : IRequest
    {
        public int Id { get; set; }
    }
}
