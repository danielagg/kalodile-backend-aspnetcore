using AutoMapper;
using kalodile.Controllers.ListingItem.Dto;

namespace kalodile.Controllers.ListingItem.Mapping
{
    public class ListingItemToDtoMapper : Profile
    {
        public ListingItemToDtoMapper()
        {
            CreateMap<Domain.ListingItem.ListingItem, ListingItemDto>();
        }
    }
}
