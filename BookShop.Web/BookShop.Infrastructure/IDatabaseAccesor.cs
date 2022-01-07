using BookShop.Core.Entities;

namespace BookShop.Infrastructure
{
    public interface IDatabaseAccesor
    {
        void CreateNewShop(Shop shop);
    }
}
