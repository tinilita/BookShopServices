using System;
using System.Collections.Generic;
using BookShop.ApplicationServices;
using BookShop.ApplicationServices.Models;
using BookShop.Web.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BookShop.Web.Controllers
{
    [Route("api/shop")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private readonly IShopService _shopService; // 1)меня смущает то, что таких вот конструкций здесь две
        
        public ShopController(IShopService shopService) //2)
        {
            _shopService = shopService;
            /*
             * 1. добавить разделение приложения по слоям (ApplicationServices, Infrastructure, Core)
             * 2. добавить абстракции и модели для прохождения флоу "добавление магазина"
             * 3. установить SQLite ***
             * 4. прочитать про EF, миграции ***
             * 
             */
        }

        [HttpGet("")]
        public List<AddShopModel> GetAllShops()
        {
            return new()
            {
                new AddShopModel()
                {
                    Name = "Лабиринт",
                    Adress = "Пушкина, дом 3"
                },
                new AddShopModel()
                {
                    Name = "Киви",
                    Adress = "Сковорода, строение 52"
                }

            };
        }

        [HttpPost("add")]
        public void AddNewShop([FromBody] AddShopRequest request)
        {
            _shopService.AddNewShop(new AddShopModel // оно как-то конфликтует с тем, что у нас в [HttpGet...]?
            {
                Name = request.Name, //Почему это не в поле видимости?
                Adress = request.Address
            });
        }

        [HttpGet("/list-books/{shopId}")]
        public void ListShopBooks(Guid shopId)
        {
        }

    }
}
