using MediatR;

namespace Application.Features.Doctors.Commands.Delete
{
    public class DeleteDoctorCommand : IRequest
    {
        public int Id { get; set; }
    }
}
