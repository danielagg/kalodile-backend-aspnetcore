using kalodile.Controllers.ListingItem.Dto;
using MediatR;

namespace kalodile.Domain.ListingItem.Command
{
    public class CreateListingItemQuery : IRequest<ListingItemDto>
    {
        public ListingItemCreate Data { get; }

        public CreateListingItemQuery(ListingItemCreate request)
        {
            Data = request;
        }
    }
}
