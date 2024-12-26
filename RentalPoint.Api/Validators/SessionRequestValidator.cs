using FluentValidation;
using TicketBookingApplication.Api.Dto;

namespace TicketBookingApplication.Api.Validators
{
    public class SessionRequestValidator : AbstractValidator<SessionRequest>
    {
        public SessionRequestValidator()
        {
            RuleFor(s => s.Price)
                .GreaterThan(0)
                .WithMessage("Prices value has to be greater than 0");

            RuleFor(s => s.AvailableQuantity)
                .GreaterThan(0)
                .WithMessage("Availdbale quantity has to be greater than 0");
        }
    }
}
