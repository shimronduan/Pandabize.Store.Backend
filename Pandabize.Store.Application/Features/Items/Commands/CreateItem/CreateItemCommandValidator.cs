using FluentValidation;

namespace Pandabize.Store.Application.Features.Items.Commands.CreateItem
{
    public class CreateItemCommandValidator : AbstractValidator<CreateItemCommand>
    {
        public CreateItemCommandValidator()
        {
            RuleFor(p => p.Name)
               .NotEmpty().WithMessage("{PropertyName} is required.")
               .NotNull()
               .MaximumLength(20).WithMessage("{PropertyName} must not exceed 20 characters.");
        }
    }
}
