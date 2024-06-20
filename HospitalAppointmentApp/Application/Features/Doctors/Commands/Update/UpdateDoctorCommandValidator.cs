using FluentValidation;

namespace Application.Features.Doctors.Commands.Update
{
    public class UpdateDoctorCommandValidator : AbstractValidator<UpdateDoctorCommand>
    {
        public UpdateDoctorCommandValidator()
        {
            RuleFor(d => d.FirstName).NotEmpty().WithMessage("First name cannot be empty.");
        }
    }
}
