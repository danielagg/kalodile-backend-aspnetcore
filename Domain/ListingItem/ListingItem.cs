using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kalodile.Domain.ListingItem
{
    public class ListingItem : Entity
    {
        public string Name { get; }

        public static ListingItem Create(
            string name)
        {
            return new ListingItem(name);
        }

        private ListingItem(
            string name)
        {
            Name = name;

            Id = Guid.NewGuid();
            CreatedOn = DateTime.UtcNow;
        }
    }
}
