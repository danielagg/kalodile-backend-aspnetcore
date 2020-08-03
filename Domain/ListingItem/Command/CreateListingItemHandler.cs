using AutoMapper;
using kalodile.Controllers.ListingItem.Dto;
using kalodile.Domain.ListingItem.Exceptions;
using kalodile.Infrastructure.EntityFrameworkCore;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace kalodile.Domain.ListingItem.Command
{
    public class CreateListingItemHandler : IRequestHandler<CreateListingItemQuery, ListingItemDto>
    {
        private readonly ListingItemRepository _repository;
        private readonly IMapper _mapper;

        public CreateListingItemHandler(
            ListingItemRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ListingItemDto> Handle(CreateListingItemQuery request, CancellationToken cancellationToken)
        {
            if (request?.Data == null)
                throw new ListingItemCannotBeCreatedException();

            var model = ListingItem.Create(request.Data);
            var result = await _repository.Insert(model);

            return _mapper.Map<ListingItemDto>(result);
        }
    }
}
