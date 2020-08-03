using System;

namespace kalodile.Domain.ListingItem
{
    public class ListingItem : Entity
    {
        public string Name { get; private set; }
        public ListingCategory Category { get; private set; }

        // necessary for EF Core
        protected ListingItem() { }

        public static ListingItem Create(ListingItemCreate data)
        {
            return new ListingItem(
                data.Name,
                data.Category);
        }

        private ListingItem(
            string name,
            ListingCategory category)
        {
            Name = name;
            Category = category;

            Id = GenerateId();
            CreatedOn = DateTime.UtcNow;
        }
    }
}
