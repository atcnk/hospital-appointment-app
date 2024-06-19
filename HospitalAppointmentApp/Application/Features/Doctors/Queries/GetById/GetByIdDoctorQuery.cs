using MediatR;

namespace Application.Features.Doctors.Queries.GetById
{
    public class GetByIdDoctorQuery : IRequest<GetByIdDoctorResponse>
    {
        public int Id { get; set; }
    }
}
