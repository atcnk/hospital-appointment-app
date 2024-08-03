﻿using FluentValidation;

namespace Application.Features.Users.Commands.Create
{
	public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
	{
		public CreateUserCommandValidator()
		{
			RuleFor(i => i.PhoneNumber)
			.Matches(@"^\+90\d{10}$").NotEmpty()
			.WithMessage("The phone number must start with +90 and have 10 digits.");
			RuleFor(user => user.Email)
			.NotEmpty().WithMessage("Email can not be empty.")
			.EmailAddress().WithMessage("Enter a valid e-mail address..");
			RuleFor(i => i.FirstName).NotEmpty().WithMessage("FirstName can not be empty.");
			RuleFor(i => i.LastName).NotEmpty().WithMessage("LastName can not be empty.");
			RuleFor(i => i.Password).NotEmpty().WithMessage("Password can not be empty.");
			RuleFor(i => i.BirthDate).Must(CheckBirthDate).WithMessage("BirthDate must be greater than 18 years.");
		}

		public bool CheckBirthDate(DateTime birthDate)
		{
			int difference = DateTime.Now.Year - birthDate.Year;
			if (difference >= 18)
			{
				return true;
			}
			return false;
		}
	}
}
