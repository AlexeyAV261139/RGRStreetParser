using FluentValidation;
using RGRStreetParser.Models;

namespace RGRStreetParser.Validators;

public class InitialsValidator : AbstractValidator<Initials>
{
    public InitialsValidator()
    {
        RuleFor(initials => initials.Surname)
            .NotNull()
            .MinimumLength(2);

        RuleFor(initials => initials.Name)
            .NotNull()
            .Length(1);

        RuleFor(initials => initials.Patronymic)
            .NotNull()
            .Length(1);
    }
}
