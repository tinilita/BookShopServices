using BookShop.ApplicationServices.Models;

namespace BookShop.ApplicationServices
{
    public interface IShopService
    {
        void AddNewShop(AddShopModel model);
    }
}
