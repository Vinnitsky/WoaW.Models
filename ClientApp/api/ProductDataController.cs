using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace WoaW.Models.Products.Controllers
{
    [Route("api/[controller]")]
    public class ProductDataController : Controller
    {
        private static List<ProductModel> _products;
        static ProductDataController()
        {
            _products = new List<ProductModel>();
            // {
            //     new ProductModel(){
            //         Id="0001", Name="Product 1", Description="Description for Product",
            //         Price="$ 12.20", Quantity="233",Status=1,Added="04/10/2017"
            //     },
            //     new ProductModel(){
            //         Id="0002", Name="Product 2", Description="Description for Product",
            //         Price="$ 12.20", Quantity="243",Status=2,Added="04/10/2017"
            //     },
            //     new ProductModel(){
            //         Id="0003", Name="Product 3", Description="Description for Product",
            //         Price="$ 14.00", Quantity="253",Status=3,Added="04/10/2017"
            //     },
            //      new ProductModel(){
            //         Id="0004", Name="Product 4", Description="Description for Product",
            //         Price="$ 16.20", Quantity="233",Status=1,Added="04/10/2017"
            //     },
            //     new ProductModel(){
            //         Id="0005", Name="Product 5", Description="Description for Product",
            //         Price="$ 14.20", Quantity="243",Status=2,Added="04/10/2017"
            //     },
            //      new ProductModel(){
            //         Id="0006", Name="Product 6", Description="Description for Product",
            //         Price="$ 12.20", Quantity="233",Status=1,Added="04/10/2017"
            //     },
            //     new ProductModel(){
            //         Id="0007", Name="Product 7", Description="Description for Product",
            //         Price="$ 12.20", Quantity="243",Status=2,Added="04/10/2017"
            //     },
            //     new ProductModel(){
            //         Id="0008", Name="Product 8", Description="Description for Product",
            //         Price="$ 14.00", Quantity="253",Status=3,Added="04/10/2017"
            //     },
            //      new ProductModel(){
            //         Id="0009", Name="Product 9", Description="Description for Product",
            //         Price="$ 16.20", Quantity="233",Status=1,Added="04/10/2017"
            //     },
            //     new ProductModel(){
            //         Id="0010", Name="Product 10", Description="Description for Product",
            //         Price="$ 14.20", Quantity="243",Status=2,Added="04/10/2017"
            //     },

            //     new ProductModel(){
            //         Id="0011", Name="Product 11", Description="Description for Product",
            //         Price="$ 12.20", Quantity="233",Status=1,Added="04/10/2017"
            //     },
            //     new ProductModel(){
            //         Id="0012", Name="Product 12", Description="Description for Product",
            //         Price="$ 12.20", Quantity="243",Status=2,Added="04/10/2017"
            //     },
            //     new ProductModel(){
            //         Id="0013", Name="Product 13", Description="Description for Product",
            //         Price="$ 14.00", Quantity="253",Status=3,Added="04/10/2017"
            //     },
            //      new ProductModel(){
            //         Id="0014", Name="Product 14", Description="Description for Product",
            //         Price="$ 16.20", Quantity="233",Status=1,Added="04/10/2017"
            //     },
            //     new ProductModel(){
            //         Id="0015", Name="Product 15", Description="Description for Product",
            //         Price="$ 14.20", Quantity="243",Status=2,Added="04/10/2017"
            //     },
            //      new ProductModel(){
            //         Id="0016", Name="Product 16", Description="Description for Product",
            //         Price="$ 12.20", Quantity="233",Status=1,Added="04/10/2017"
            //     },
            //     new ProductModel(){
            //         Id="0017", Name="Product 17", Description="Description for Product",
            //         Price="$ 12.20", Quantity="243",Status=2,Added="04/10/2017"
            //     },
            //     new ProductModel(){
            //         Id="0018", Name="Product 18", Description="Description for Product",
            //         Price="$ 14.00", Quantity="253",Status=3,Added="04/10/2017"
            //     },
            //      new ProductModel(){
            //         Id="0019", Name="Product 19", Description="Description for Product",
            //         Price="$ 16.20", Quantity="233",Status=1,Added="04/10/2017"
            //     },
            //     new ProductModel(){
            //         Id="0020", Name="Product 20", Description="Description for Product",
            //         Price="$ 14.20", Quantity="243",Status=2,Added="04/10/2017"
            //     },

            // };
        }

        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet()]
        public IEnumerable<ProductModel> Get()
        {
            return GetProducts();
        }
        [HttpGet()]
        public IEnumerable<ProductModel> Get([FromRoute]string id)
        {
            return GetProducts();
        }

        [HttpGet("[action]")]
        public IEnumerable<ProductModel> GetProducts()
        {
            return _products;
            // var rng = new Random();
            // return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            // {
            //     DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
            //     TemperatureC = rng.Next(-20, 55),
            //     Summary = Summaries[rng.Next(Summaries.Length)]
            // });
        }

        [HttpPut()]
        public async void Put([FromBody]ProductModel body)
        {
            //var json = Request.Content.ReadAsStringAsync();
            //using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            //{
            //    var json = await reader.ReadToEndAsync();
            //    var model = JsonConvert.DeserializeObject<ProductModel>(json);
            //}

            try
            {
                System.Diagnostics.Debug.WriteLine("Ok");
                body.Added = DateTime.Now.ToString();
                _products.Add(body);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

        //public async void Post([FromBody]string id, [FromBody]ProductModel body)
        [HttpPost()]
        public async void Post([FromBody]string id, [FromBody]ProductModel model)
        {
            //var json = Request.Content.ReadAsStringAsync();
            //using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            //{
            //    var json = await reader.ReadToEndAsync();
            //    var model = JsonConvert.DeserializeObject<ProductModel>(json);
            //}

            try
            {

                System.Diagnostics.Debug.WriteLine("Ok");
                model.Added = DateTime.Now.ToString();
                _products.Add(model);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
    }
}
