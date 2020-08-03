using kalodile.Domain.ListingItem.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace kalodile.Controllers.ListingItem
{
    public class ListingItemController : KalodileBaseController
    {
        private readonly IMediator _mediator;
        public ListingItemController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetListingItemById(string id)
        {
            var query = new GetListingItemQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}