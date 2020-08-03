using System;

namespace kalodile.Domain.ListingItem
{
    public class ListingItem : Entity
    {
        public string Name { get; private set; }
        public string Type { get; private set; }

        // necessary for EF Core
        protected ListingItem() { }

        public static ListingItem Create(ListingItemCreate data)
        {
            return new ListingItem(
                data.Name,
                data.Type);
        }

        private ListingItem(
            string name,
            string type)
        {
            Name = name;
            Type = type;

            Id = GenerateId();
            CreatedOn = DateTime.UtcNow;
        }
    }
}
