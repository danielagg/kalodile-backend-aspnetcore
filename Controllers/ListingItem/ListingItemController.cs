using AutoMapper;
using kalodile.Controllers.ListingItem.Dto;
using kalodile.Domain.ListingItem;
using kalodile.Domain.ListingItem.Command;
using kalodile.Domain.ListingItem.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace kalodile.Controllers.ListingItem
{
    public class ListingItemController : KalodileBaseController
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public ListingItemController(
            IMediator mediator,
            IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetById(string id)
        {
            var query = new GetListingItemQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ListingItemCreateRequestDto item)
        {
            var request = _mapper.Map<ListingItemCreate>(item);
            var query = new CreateListingItemQuery(request);

            var result = await _mediator.Send(query);
            return Ok(result);
        }        
    }
}