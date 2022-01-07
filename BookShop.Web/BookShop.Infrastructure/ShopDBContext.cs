using BookShop.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Infrastructure
{

    public class ShopDBContext : DbContext, IDatabaseAccesor
    {
        public const string DefaultShemaName = "Shop";

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            modelBuilder.HasDefaultSchema(DefaultShemaName);
        }

        public void CreateNewShop(Shop newShop)
        {
            Add(newShop);
        }
    }
}
