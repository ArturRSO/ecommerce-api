using ECommerceAPI.Data;
using ECommerceAPI.Services.Interfaces;
using Product_API.Models;

namespace ECommerceAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly ECommerceContext _database;

        public ProductService(ECommerceContext database)
        {
            _database = database;
        }

        public IEnumerable<Product> Get()
        {
            return _database.Products;
        }
    }
}
