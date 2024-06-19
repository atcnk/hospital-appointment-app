using MediatR;

namespace Application.Features.DoctorSchedules.Queries.GetById
{
    public class GetByIdDoctorScheduleQuery : IRequest<GetByIdDoctorScheduleResponse>
    {
        public int Id { get; set; }
    }
}
