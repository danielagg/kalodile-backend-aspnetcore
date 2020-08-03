using kalodile.Controllers.ListingItem;
using MediatR;
using System;

namespace kalodile.Domain.ListingItem.Query
{
    public class GetListingItemQuery : IRequest<ListingItemDto>
    {
        public string Id { get; }

        public GetListingItemQuery(string id)
        {
            Id = id;
        }
    }
}
