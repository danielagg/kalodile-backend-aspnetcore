using kalodile.Infrastructure.Exceptions;
using System;

namespace kalodile.Domain.ListingItem.Exceptions
{
    public class ListingItemDoesNotExistException : NotFoundException
    {
        public ListingItemDoesNotExistException() : base("The listing item does not exist.") { }
    }
}
