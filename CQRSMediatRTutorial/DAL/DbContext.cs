using DAL.Entities;
using System;
using System.Collections.Generic;

namespace DAL
{
    public class DbContext
    {
        static List<Product> productList = new List<Product> {
         new() { Id = Guid.NewGuid(), Name = "Apple Watch Ultra 2", Price = (decimal) 799.00, Quantity = 52, CreateTime = DateTime.Now, Image = "https://m.media-amazon.com/images/I/81LaeWvEbGL.__AC_SY445_SX342_QL70_FMwebp_.jpg" },
         new() { Id = Guid.NewGuid(), Name = "Apple iPad Pro 12", Price = (decimal) 1083.00, Quantity = 12, CreateTime = DateTime.Now, Image = "https://m.media-amazon.com/images/I/81c+9BOQNWL._AC_SX522_.jpg" },
         new() { Id = Guid.NewGuid(), Name = "Apple Watch Series 9", Price = (decimal) 399.00, Quantity = 7, CreateTime = DateTime.Now, Image = "https://m.media-amazon.com/images/I/61fyMOZWp8L.__AC_SY445_SX342_QL70_FMwebp_.jpg" },
         new() { Id = Guid.NewGuid(), Name = "Apple AirPods Max", Price = (decimal) 419.99, Quantity = 24, CreateTime = DateTime.Now, Image = "https://m.media-amazon.com/images/I/81jlI96l0VL._AC_SX679_.jpg" },
         new() { Id = Guid.NewGuid(), Name = "Apple 2021 TV HD", Price = 79, Quantity = 81, CreateTime = DateTime.Now, Image = "https://m.media-amazon.com/images/I/61XiobVRcFS._AC_UY327_FMwebp_QL65_.jpg" },
         new() { Id = Guid.NewGuid(), Name = "Apple Smart Keyboard Folio", Price = (decimal) 79.97, Quantity = 60, CreateTime = DateTime.Now, Image = "https://m.media-amazon.com/images/I/511Mq6HRrNL._AC_UY327_FMwebp_QL65_.jpg" },
         new() { Id = Guid.NewGuid(), Name = "Apple Magic Keyboard", Price = (decimal) 82.00, Quantity = 60, CreateTime = DateTime.Now, Image = "https://m.media-amazon.com/images/I/714lWFvp4XL._AC_UY327_FMwebp_QL65_.jpg" },
         new() { Id = Guid.NewGuid(), Name = "Apple TV Remote", Price = (decimal) 19.95, Quantity = 60, CreateTime = DateTime.Now, Image = "https://m.media-amazon.com/images/I/41jKT9IdmUL._AC_UL480_FMwebp_QL65_.jpg" },
         new() { Id = Guid.NewGuid(), Name = "Apple iPad Mini", Price = (decimal) 99.00, Quantity = 60, CreateTime = DateTime.Now, Image = "https://m.media-amazon.com/images/I/619utiOsCrL._AC_UL480_FMwebp_QL65_.jpg" },
         new() { Id = Guid.NewGuid(), Name = "Apple AirPort Extreme Base Station", Price = (decimal) 129.01, Quantity = 60, CreateTime = DateTime.Now, Image = "https://m.media-amazon.com/images/I/41libuUP0IL._AC_UL480_FMwebp_QL65_.jpg" },
         new() { Id = Guid.NewGuid(), Name = "Apple Thunderbolt 4 Pro Cable", Price = (decimal) 129.00, Quantity = 60, CreateTime = DateTime.Now, Image = "https://m.media-amazon.com/images/I/71grKCk9ntL._AC_UL480_FMwebp_QL65_.jpg" },
         new() { Id = Guid.NewGuid(), Name = "Apple Studio Display", Price = (decimal) 1959.00, Quantity = 60, CreateTime = DateTime.Now, Image = "https://m.media-amazon.com/images/I/71I1KXzxHIL._AC_UL480_FMwebp_QL65_.jpg" },
        };
        public static List<Product> ProductList => productList;
    }
}
