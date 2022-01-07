using Microsoft.EntityFrameworkCore;

namespace BookShop.Infrastructure.EntityFramework
{
    public class ShopDBContextDesignTimeFactory
    {
        private const string DefaultConnectionString =
            "Data Source=127.0.0.1;Initial Catalog=BookShop; User Id=sa; Password=2wsx2WSX;";

        public static DbContextOptions<ShopDBContext> GetSqlServerOptions(string connectionString)
        {
            return new DbContextOptionsBuilder<ShopDBContext>()
                .UseSqlServer(connectionString ?? DefaultConnectionString, x =>
                {
                    x.MigrationsHistoryTable("__EFMigrationsHistory", ShopDBContext.DefaultShemaName);
                })
                .Options;
        }
    }
}