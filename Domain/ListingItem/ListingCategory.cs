using kalodile.Infrastructure;
using System.Collections.Generic;

namespace kalodile.Domain.ListingItem
{
    public class ListingCategory : ValueObject
    {
        public string MainCategory { get; private set; }
        public string SubCategory1 { get; private set; }
        public string SubCategory2 { get; private set; }
        public string SubCategory3 { get; private set; }

        private ListingCategory() { }

        public ListingCategory(
            string mainCategory,
            string subCategory1,
            string subCategory2,
            string subCategory3)
        {
            MainCategory = mainCategory;
            SubCategory1 = subCategory1;
            SubCategory2 = subCategory2;
            SubCategory3 = subCategory3;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return MainCategory;
            yield return SubCategory1;
            yield return SubCategory2;
            yield return SubCategory3;
        }
    }
}
