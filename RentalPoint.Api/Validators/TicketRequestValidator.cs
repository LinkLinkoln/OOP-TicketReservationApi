using FluentValidation;
using TicketBookingApplication.Api.Dto;

namespace TicketBookingApplication.Api.Validators
{
    public class TicketRequestValidator : AbstractValidator<SessionRequest>
    {
        public TicketRequestValidator()
        {
            RuleFor(p => p.Price).Cascade(CascadeMode.Stop)
                .Must(n => n > 0).WithMessage("Price has to be greater than 0");

            RuleFor(p => p.AvailableQuantity).Cascade(CascadeMode.Stop)
                .Must(n => n > 0).WithMessage("Available Quantity has to be greater than 0");
        }
    }
}
