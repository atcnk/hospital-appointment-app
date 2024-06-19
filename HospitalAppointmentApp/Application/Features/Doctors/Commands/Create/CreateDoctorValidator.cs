using FluentValidation;

namespace Application.Features.Doctors.Commands.Create
{
    public class CreateDoctorValidator : AbstractValidator<CreateDoctorCommand>
    {
        public CreateDoctorValidator() 
        {
            RuleFor(d => d.FirstName).NotEmpty().WithMessage("First name cannot be empty.");
        }
    }
}
