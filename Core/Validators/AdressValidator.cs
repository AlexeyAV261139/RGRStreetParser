using FluentValidation;
using RGRStreetParser.Models;

namespace RGRStreetParser.Validators;

public class AdressValidator : AbstractValidator<Adress>
{
    public AdressValidator()
    {
        RuleFor(adress => adress.Street)
            .NotNull()
            .NotEmpty();

        RuleFor(adress => adress.HouseNumber)
            .NotNull()
            .NotEmpty();

        RuleFor(adress => adress.ApartmentNumber)
            .NotNull()
            .NotEmpty();
    }
}
