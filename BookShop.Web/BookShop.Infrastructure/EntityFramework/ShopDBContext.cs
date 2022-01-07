using BookShop.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Infrastructure.EntityFramework
{

    public class ShopDBContext : DbContext
    {
        public const string DefaultShemaName = "Shop";

        public ShopDBContext(DbContextOptions options) : base(options) 
        {
            
        }
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
