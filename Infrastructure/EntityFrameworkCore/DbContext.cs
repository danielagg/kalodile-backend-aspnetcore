using kalodile.Domain.ListingItem;
using Microsoft.EntityFrameworkCore;

namespace kalodile.Infrastructure.EntityFrameworkCore
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<ListingItem> ListingItems { get; set; }

        public DbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnCreatingListItems(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private void OnCreatingListItems(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ListingItem>().ToContainer("ListingItems");

            modelBuilder.Entity<ListingItem>().OwnsOne(o => o.Category);
        }
    }
}
