using AutoMapper;

namespace kalodile.Controllers.ListingItem
{
    public class ListingItemToDtoMapper : Profile
    {
        public ListingItemToDtoMapper()
        {
            CreateMap<Domain.ListingItem.ListingItem, ListingItemDto>();
        }
    }
}
