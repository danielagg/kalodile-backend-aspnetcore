using AutoMapper;
using kalodile.Controllers.ListingItem.Dto;
using kalodile.Domain.ListingItem.Exceptions;
using kalodile.Infrastructure.EntityFrameworkCore;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace kalodile.Domain.ListingItem.Query
{
    public class GetListingItemHandler : IRequestHandler<GetListingItemQuery, ListingItemDto>
    {
        private readonly ListingItemRepository _repository;
        private readonly IMapper _mapper;

        public GetListingItemHandler(
            IMapper mapper,
            ListingItemRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<ListingItemDto> Handle(GetListingItemQuery request, CancellationToken cancellationToken)
        {
            var item = await _repository.FindById(request.ListingItemId);

            if (item == null)
                throw new ListingItemDoesNotExistException();

            return _mapper.Map<ListingItemDto>(item);
        }
    }
}
