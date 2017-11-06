using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace WoaW.Models.Products.Controllers
{
    [Route("api/[controller]")]
    public class ProductDataController : Controller
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet()]
        public IEnumerable<ProductModel> Get()
        {
            return GetProducts();
        }

        [HttpGet("[action]")]
        public IEnumerable<ProductModel> GetProducts()
        {
            var products =  new List<ProductModel>()
            {
                new ProductModel(){
                    Id="0001", Name="Product 1", Description="Description for Product",
                    Price="$ 12.20", Quantity="233",Status=1,Added="04/10/2015"
                },
                new ProductModel(){
                    Id="0002", Name="Product 2", Description="Description for Product",
                    Price="$ 12.20", Quantity="243",Status=2,Added="04/10/2015"
                },
                new ProductModel(){
                    Id="0003", Name="Product 3", Description="Description for Product",
                    Price="$ 14.00", Quantity="253",Status=3,Added="04/10/2015"
                },
            };
            return products;
            // var rng = new Random();
            // return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            // {
            //     DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
            //     TemperatureC = rng.Next(-20, 55),
            //     Summary = Summaries[rng.Next(Summaries.Length)]
            // });
        }

    }
}
