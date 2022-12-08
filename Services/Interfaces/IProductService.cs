using Product_API.Models;

namespace ECommerceAPI.Services.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> Get();
    }
}
