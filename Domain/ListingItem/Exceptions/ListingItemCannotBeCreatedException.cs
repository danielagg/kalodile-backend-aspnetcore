using kalodile.Infrastructure.Exceptions;
using System;

namespace kalodile.Domain.ListingItem.Exceptions
{
    public class ListingItemCannotBeCreatedException : InternalServerErrorException
    {
        public ListingItemCannotBeCreatedException() : base("The listing item cannot be created.") { }
    }
}
