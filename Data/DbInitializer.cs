using Product_API.Models;

namespace ECommerceAPI.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ECommerceContext context)
        {
            context.Database.EnsureCreated();

            if (context.Products.Any())
            {
                return;
            }

            var products = GetTestProducts(5);

            foreach (Product product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }

        private static List<Product> GetTestProducts(int quantity)
        {
            List<Product> products = new();

            if (quantity <= 0)
            {
                return products;
            }

            for (int i = 0; i < quantity; i++)
            {
                products.Add(new Product
                {
                    Name = $"Product Test {i}",
                    Price = 100,
                    Quantity = 10,
                    ShortDescription = "Just test data"
                });
            }

            return products;
        }
    }
}
