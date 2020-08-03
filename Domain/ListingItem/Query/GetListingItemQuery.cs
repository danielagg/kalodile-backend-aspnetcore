using kalodile.Controllers.ListingItem.Dto;
using MediatR;

namespace kalodile.Domain.ListingItem.Query
{
    public class GetListingItemQuery : IRequest<ListingItemDto>
    {
        public string ListingItemId { get; }

        public GetListingItemQuery(string id)
        {
            ListingItemId = id;
        }
    }
}
