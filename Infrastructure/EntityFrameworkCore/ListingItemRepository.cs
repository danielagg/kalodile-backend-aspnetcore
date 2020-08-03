using kalodile.Domain.ListingItem;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace kalodile.Infrastructure.EntityFrameworkCore
{
    public class ListingItemRepository
    {
        private readonly DbContext _context;

        public ListingItemRepository(
            DbContext context)
        {
            _context = context;
        }

        public async Task<ListingItem> FindById(string id)
        {
            var result = await _context.ListingItems.SingleAsync(li => li.Id == id);
            return result;
        }

        public async Task<ListingItem> Insert(ListingItem model)
        {
            var result = await _context.ListingItems.AddAsync(model);
            await _context.SaveChangesAsync();

            return result.Entity;
        }
    }
}
