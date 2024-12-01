using FluentValidation;
using RGRStreetParser.Models;

namespace RGRStreetParser.Validators;

public class AdressValidator : AbstractValidator<Adress>
{
    public AdressValidator()
    {
        RuleFor(adress => adress.Street)
            .NotNull()
            .MinimumLength(2);

        RuleFor(adress => adress.HouseNumber)
            .NotNull()
            .MinimumLength(2);

        RuleFor(adress => adress.ApartmentNumber)
            .NotNull()
            .MinimumLength(2);
    }
}
