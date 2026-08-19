using CoreWebApisWithDockerFile.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApisWithDockerFile.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        public static List<Product> products;
        public ProductApiController()
        {
            products = GetInitialProducts();

        }
        [HttpGet]
        [Route("api/product")]
        public List<Product> GetProducts()
        {
             return products;
        }
        [HttpGet]
        [Route("api/product/{id}")]
        public Product GetProduct(int id)
        {
            return products.FirstOrDefault(e => e.ProductId.Equals(id));
        }

        [NonAction]
        public List<Product> GetInitialProducts()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product() { ProductId = 1, ProductName = "Sugar", Gst = 5, Rate = 42, StockQuantity = 120 });
            products.Add(new Product() { ProductId = 2, ProductName = "Soap", Gst = 12, Rate = 32, StockQuantity = 100 });
            products.Add(new Product() { ProductId = 3, ProductName = "Rice", Gst = 9, Rate = 80, StockQuantity = 78 });
            products.Add(new Product() { ProductId = 4, ProductName = "Oil", Gst = 18, Rate = 120, StockQuantity = 60 });
            products.Add(new Product() { ProductId = 5, ProductName = "Tea Powder", Gst = 12, Rate = 100, StockQuantity = 10 });
            return products;
        }

        [HttpGet]
        [Route("api/testapi")]
        public string  TestSampleApi()
        {
            return  "This is Test Api";
        }
 [HttpGet]
        [Route("api/testsecondapi")]
        public string  TestSecondApi()
        {
            return  "This is Second Test Api";
        }

    }
}
