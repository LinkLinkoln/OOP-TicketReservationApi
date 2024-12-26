using FluentValidation;
using TicketBookingApplication.Api.Dto;

namespace TicketBookingApplication.Api.Validators
{
    public class ClientRequestValidator : AbstractValidator<ClientRequest>
    {
        public ClientRequestValidator()
        {
            RuleFor(p => p.FirstName).Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("First Name is required.")
                .Must(n => n.Length >= 4).WithMessage("First Name's length has to be at least 4")
                .Must(n => n.Length < 50).WithMessage("First Name's length cannot exceed 50 characters");

            RuleFor(p => p.LastName).Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Last Name is required.")
                .Must(n => n.Length >= 4).WithMessage("Last Name's length has to be at least 4")
                .Must(n => n.Length < 50).WithMessage("Last Name's length cannot exceed 50 characters");

            RuleFor(l => l.Email)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Incorrect email entered");

            RuleFor(l => l.PhoneNumber)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Phone number is required.")
                .Matches(@"^\+?[1-9]\d{1,14}$").WithMessage("Invalid phone number format.");
        }
    }
}
