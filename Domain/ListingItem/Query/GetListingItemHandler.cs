using AutoMapper;
using kalodile.Controllers.ListingItem;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace kalodile.Domain.ListingItem.Query
{
    public class GetListingItemHandler : IRequestHandler<GetListingItemQuery, ListingItemDto>
    {
        private readonly IMapper _mapper;

        public GetListingItemHandler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<ListingItemDto> Handle(GetListingItemQuery request, CancellationToken cancellationToken)
        {
            var item =  await Task.FromResult(ListingItem.Create("Boss DS-1"));
            return _mapper.Map<ListingItemDto>(item);
        }
    }
}
