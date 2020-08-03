using FluentValidation;

namespace kalodile.Domain.ListingItem.Command
{
    public class CreateListingItemCommandValidator : AbstractValidator<CreateListingItemCommand>
    {
        public CreateListingItemCommandValidator()
        {
            RuleFor(x => x.Data.Name).NotEmpty();
            RuleFor(x => x.Data.Category.MainCategory).NotEmpty();
        }
    }
}
