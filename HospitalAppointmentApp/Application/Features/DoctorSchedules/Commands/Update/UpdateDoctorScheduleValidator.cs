using FluentValidation;

namespace Application.Features.DoctorSchedules.Commands.Update
{
    public class UpdateDoctorScheduleValidator : AbstractValidator<UpdateDoctorScheduleCommand>
    {
        public UpdateDoctorScheduleValidator()
        {
            RuleFor(ds => ds.AvailableDate).NotEmpty().WithMessage("Available date cannot be empty.");
        }
    }
}
