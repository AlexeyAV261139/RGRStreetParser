using FluentValidation;
using RGRStreetParser.Models;
using System.Text.RegularExpressions;

namespace RGRStreetParser.Validators;

public class SubscribersDataValidator : AbstractValidator<SubscribersData>
{
    public SubscribersDataValidator()
    {
        RuleFor(subscribers => subscribers.Initials)
            .SetValidator(new InitialsValidator());

        RuleFor(subscribers => subscribers.Adress)
           .SetValidator(new AdressValidator());

        RuleFor(subscribers => subscribers.PhoneNumber)
            .NotEmpty()
            .NotNull()
            .Matches(new Regex(@"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$"))
                .WithMessage("Невалидный номер телефона");        
    }
}
