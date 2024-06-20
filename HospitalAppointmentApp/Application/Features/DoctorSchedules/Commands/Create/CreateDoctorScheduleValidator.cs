using FluentValidation;

namespace Application.Features.DoctorSchedules.Commands.Create
{
    public class CreateDoctorScheduleValidator : AbstractValidator<CreateDoctorScheduleCommand>
    {
        public CreateDoctorScheduleValidator()
        {
            RuleFor(ds => ds.AvailableDate).NotEmpty().WithMessage("Available date cannot be empty.");
        }
    }
}
