using AutoMapper;
using kalodile.Controllers.ListingItem.Dto;
using kalodile.Domain.ListingItem;

namespace kalodile.Controllers.ListingItem.Mapping
{
    public class ListingItemCreateRequestDtoToListingItemCreateMapper : Profile
    {
        public ListingItemCreateRequestDtoToListingItemCreateMapper()
        {
            CreateMap<ListingItemCreateRequestDto, ListingItemCreate>();
        }
    }
}
