using FluentValidation;
using kalodile.Controllers.ListingItem.Dto;
using kalodile.Infrastructure.EntityFrameworkCore;
using MediatR;

namespace kalodile.Domain.ListingItem.Command
{
    public class CreateListingItemCommandValidator : AbstractValidator<CreateListingItemCommand>
    {
        public CreateListingItemCommandValidator()
        {
            RuleFor(x => x.Data.Name).NotEmpty();
            RuleFor(x => x.Data.Type).NotEmpty();
        }
    }
}
