using System;

namespace BookShop.Core.Entities
{
    public class Book
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Shop Shop { get; set; }
        public Guid ShopId { get; set; }
    }
}