using System;
using System.Collections.Generic;

namespace BookShop.Core.Entities
{
    public class Shop
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Address { get; set; }
        public int Capacity { get; set; }
        public List<Book> Books { get; set; }
    }
}