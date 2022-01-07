using BookShop.ApplicationServices.Models;
using BookShop.Core.Entities;
using BookShop.Infrastructure;
using BookShop.Infrastructure.EntityFramework;

namespace BookShop.ApplicationServices
{
    public class ShopService : IShopService
    {
        private readonly ShopDBContext _shopDbContext;
        public ShopService(ShopDBContext shopDbContext)
        {
            _shopDbContext = shopDbContext;
        }
        public void AddNewShop(AddShopModel model)
        {
            var newshop = new Shop
            {
                Name = model.Name, 
                Address = model.Adress
            };
            _shopDbContext.CreateNewShop(newshop);
        }
    }
}
