using FluentValidation;
using SkyfallAPI.Models;

namespace SkyfallAPI.Validators;

public class SpellValidator : AbstractValidator<Spell>
{
    public SpellValidator()
    {
        RuleFor(x => x.Id).NotNull();
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.Action).IsInEnum();
        RuleFor(x => x.Cost).NotNull();
        RuleFor(x => x.Description).MaximumLength(1000);
        RuleFor(x => x.Execution).MaximumLength(50);
        RuleFor(x => x.Range).NotEmpty().MaximumLength(50);
        RuleFor(x => x.Target).NotEmpty().MaximumLength(50);
        RuleFor(x => x.Components).MaximumLength(50);
        RuleFor(x => x.Duration).NotEmpty().MaximumLength(50);
        RuleFor(x => x.Attack).MaximumLength(50);
        RuleFor(x => x.Effect).NotEmpty().MaximumLength(1000);
        RuleFor(x => x.Layer).IsInEnum();
    }
}
