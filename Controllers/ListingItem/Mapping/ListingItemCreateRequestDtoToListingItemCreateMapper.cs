using AutoMapper;
using kalodile.Controllers.ListingItem.Dto;
using kalodile.Domain.ListingItem;
using System;

namespace kalodile.Controllers.ListingItem.Mapping
{
    public class ListingItemCreateRequestDtoToListingItemCreateMapper : Profile
    {
        public ListingItemCreateRequestDtoToListingItemCreateMapper()
        {
            CreateMap<ListingItemCreateRequestDto, ListingItemCreate>()
                .ForMember(dest =>
                    dest.Category,
                    opt => opt.MapFrom(src => GetListingCategory(src)));
        }

        private ListingCategory GetListingCategory(ListingItemCreateRequestDto src)
        {
            return new ListingCategory(
                src.MainCategory,
                src.SubCategory1,
                src.SubCategory2,
                src.SubCategory3);
        }
    }
}
