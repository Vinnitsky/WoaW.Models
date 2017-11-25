using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;

namespace WoaW.Models.Products.Controllers
{
    //[Authorize]
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    public class ProductDataController : Controller
    {
        private static List<ProductModel> _products;
        private static string _rootPath;

        static ProductDataController()
        {
            //https://stackoverflow.com/questions/1495504/get-current-application-physical-path-within-application-start
            var p = AppDomain.CurrentDomain.BaseDirectory;
            var rootPath = Path.Combine(p, @"..\..\..\");
            _rootPath = Directory.CreateDirectory(rootPath + "Data").FullName;

            _products = new List<ProductModel>();
            //CreateDummyData();
        }
        public ProductDataController()
        {
            Load();
        }

        [HttpGet()]
        public IEnumerable<ProductModel> Get()
        {
            return GetProducts();
        }
        [HttpGet()]
        //[HttpGet("GetById")]
        //[HttpGet("[action]")]
        [Route("GetById")]
        public ProductModel GetById([FromRoute]string id)
        {
            if (string.IsNullOrEmpty(id))
                throw new ArgumentNullException(nameof(id));

            return _products.SingleOrDefault(x => x.Id == id);
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
        public async Task<bool> Put([FromBody]ProductModel model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            //var json = Request.Content.ReadAsStringAsync();
            //using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            //{
            //    var json = await reader.ReadToEndAsync();
            //    var model = JsonConvert.DeserializeObject<ProductModel>(json);
            //}

            try
            {
                model.Id = Guid.NewGuid().ToString("N");
                System.Diagnostics.Debug.WriteLine("Ok");
                model.Added = DateTime.Now.ToString();
                _products.Add(model);

                Save();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }

            return await Task.FromResult(true);
        }

        [HttpPost()]
        public async Task<bool> Post(string id, [FromBody]ProductModel model)
        {
            if (string.IsNullOrEmpty(id))
                throw new ArgumentNullException(nameof(id));
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            //var json = Request.Content.ReadAsStringAsync();
            //using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            //{
            //    var json = await reader.ReadToEndAsync();
            //    var model = JsonConvert.DeserializeObject<ProductModel>(json);
            //}

            try
            {
                System.Diagnostics.Debug.WriteLine("Ok");

                var item = _products.SingleOrDefault(x => x.Id == id);
                item.Name = model.Name;
                item.Description = model.Description;
                item.Quantity = model.Quantity;
                item.Price = model.Price;

                Save();

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }

            return await Task.FromResult(true);
        }

        #region implementation
        private void Save()
        {
            var productFile = Path.Combine(_rootPath, "products.json");
            string jsonString = JsonConvert.SerializeObject(_products, Formatting.Indented);
            System.IO.File.WriteAllText(productFile, jsonString);
        }
        private void Load()
        {
            var productFile = Path.Combine(_rootPath, "products.json");
            if (System.IO.File.Exists(productFile))
            {
                string jsonString = System.IO.File.ReadAllText(productFile);
                _products = JsonConvert.DeserializeObject<List<ProductModel>>(jsonString,
                    new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            }
        }
        private void CreateDummyData()
        {
            _products = new List<ProductModel>()
            {
                new ProductModel()
                {
                    Id = "0001",
                    Name = "Product 1",
                    Description = "Description for Product",
                    Price = 12.20F,
                    Quantity = 233,
                    Status = 1,
                    Added = "04/10/2017"
                },
                 new ProductModel()
                 {
                     Id = "0002",
                     Name = "Product 2",
                     Description = "Description for Product",
                     Price = 12.20F,
                     Quantity = 243,
                     Status = 2,
                     Added = "04/10/2017"
                 },
                 new ProductModel()
                 {
                     Id = "0003",
                     Name = "Product 3",
                     Description = "Description for Product",
                     Price = 14.00F,
                     Quantity = 253,
                     Status = 3,
                     Added = "04/10/2017"
                 },
                  new ProductModel()
                  {
                      Id = "0004",
                      Name = "Product 4",
                      Description = "Description for Product",
                      Price = 16.20F,
                      Quantity = 233,
                      Status = 1,
                      Added = "04/10/2017"
                  },
                 new ProductModel()
                 {
                     Id = "0005",
                     Name = "Product 5",
                     Description = "Description for Product",
                     Price = 14.20F,
                     Quantity = 243,
                     Status = 2,
                     Added = "04/10/2017"
                 },
                  new ProductModel()
                  {
                      Id = "0006",
                      Name = "Product 6",
                      Description = "Description for Product",
                      Price = 12.20F,
                      Quantity = 233,
                      Status = 1,
                      Added = "04/10/2017"
                  },
                 new ProductModel()
                 {
                     Id = "0007",
                     Name = "Product 7",
                     Description = "Description for Product",
                     Price = 12.20F,
                     Quantity = 243,
                     Status = 2,
                     Added = "04/10/2017"
                 },
                 new ProductModel()
                 {
                     Id = "0008",
                     Name = "Product 8",
                     Description = "Description for Product",
                     Price = 14.00F,
                     Quantity = 253,
                     Status = 3,
                     Added = "04/10/2017"
                 },
                  new ProductModel()
                  {
                      Id = "0009",
                      Name = "Product 9",
                      Description = "Description for Product",
                      Price = 16.20F,
                      Quantity = 233,
                      Status = 1,
                      Added = "04/10/2017"
                  },
                 new ProductModel()
                 {
                     Id = "0010",
                     Name = "Product 10",
                     Description = "Description for Product",
                     Price = 14.20F,
                     Quantity = 243,
                     Status = 2,
                     Added = "04/10/2017"
                 },

                 new ProductModel()
                 {
                     Id = "0011",
                     Name = "Product 11",
                     Description = "Description for Product",
                     Price = 12.20F,
                     Quantity = 233,
                     Status = 1,
                     Added = "04/10/2017"
                 },
                 new ProductModel()
                 {
                     Id = "0012",
                     Name = "Product 12",
                     Description = "Description for Product",
                     Price = 12.20F,
                     Quantity = 243,
                     Status = 2,
                     Added = "04/10/2017"
                 },
                 new ProductModel()
                 {
                     Id = "0013",
                     Name = "Product 13",
                     Description = "Description for Product",
                     Price = 14.00F,
                     Quantity = 253,
                     Status = 3,
                     Added = "04/10/2017"
                 },
                  new ProductModel()
                  {
                      Id = "0014",
                      Name = "Product 14",
                      Description = "Description for Product",
                      Price = 16.20F,
                      Quantity = 233,
                      Status = 1,
                      Added = "04/10/2017"
                  },
                 new ProductModel()
                 {
                     Id = "0015",
                     Name = "Product 15",
                     Description = "Description for Product",
                     Price = 14.20F,
                     Quantity = 243,
                     Status = 2,
                     Added = "04/10/2017"
                 },
                  new ProductModel()
                  {
                      Id = "0016",
                      Name = "Product 16",
                      Description = "Description for Product",
                      Price = 12.20F,
                      Quantity = 233,
                      Status = 1,
                      Added = "04/10/2017"
                  },
                 new ProductModel()
                 {
                     Id = "0017",
                     Name = "Product 17",
                     Description = "Description for Product",
                     Price = 12.20F,
                     Quantity = 243,
                     Status = 2,
                     Added = "04/10/2017"
                 },
                 new ProductModel()
                 {
                     Id = "0018",
                     Name = "Product 18",
                     Description = "Description for Product",
                     Price = 14.00F,
                     Quantity = 253,
                     Status = 3,
                     Added = "04/10/2017"
                 },
                  new ProductModel()
                  {
                      Id = "0019",
                      Name = "Product 19",
                      Description = "Description for Product",
                      Price = 16.20F,
                      Quantity = 233,
                      Status = 1,
                      Added = "04/10/2017"
                  },
                 new ProductModel()
                 {
                     Id = "0020",
                     Name = "Product 20",
                     Description = "Description for Product",
                     Price = 14.20F,
                     Quantity = 243,
                     Status = 2,
                     Added = "04/10/2017"
                 },
             };
        }
        #endregion
    }
}
