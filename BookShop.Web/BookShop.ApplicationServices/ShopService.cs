using BookShop.ApplicationServices.Models;
using BookShop.Core.Entities;
using BookShop.Infrastructure;

namespace BookShop.ApplicationServices
{
    public class ShopService : IShopService
    {
        private readonly IDatabaseAccesor _databaseAccesor;
        public ShopService(IDatabaseAccesor databaseAccesor)
        {
            _databaseAccesor = databaseAccesor;
        }
        public void AddNewShop(AddShopModel model)
        {
            var newshop = new Shop
            {
                Name = model.Name, 
                Address = model.Adress
            };
            _databaseAccesor.CreateNewShop(newshop);
        }
    }
}
