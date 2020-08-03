using kalodile.Controllers.ListingItem.Dto;
using MediatR;

namespace kalodile.Domain.ListingItem.Command
{
    public class CreateListingItemCommand : IRequest<ListingItemDto>
    {
        public ListingItemCreate Data { get; }

        public CreateListingItemCommand(ListingItemCreate request)
        {
            Data = request;
        }
    }
}
