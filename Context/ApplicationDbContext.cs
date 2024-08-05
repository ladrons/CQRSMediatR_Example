using CQRSMediatR_Example.Entities;

namespace CQRSMediatR_Example.Context
{
    public static class ApplicationDbContext
    {
        static List<Product> productList = new List<Product> {
         new() { Id = Guid.NewGuid(), Name = "Product 1", Price = 100, Quantity = 10, CreatedDate = DateTime.Now },
         new() { Id = Guid.NewGuid(), Name = "Product 2", Price = 200, Quantity = 20, CreatedDate = DateTime.Now },
         new() { Id = Guid.NewGuid(), Name = "Product 3", Price = 300, Quantity = 30, CreatedDate = DateTime.Now },
         new() { Id = Guid.NewGuid(), Name = "Product 4", Price = 400, Quantity = 40, CreatedDate = DateTime.Now },
         new() { Id = Guid.NewGuid(), Name = "Product 5", Price = 500, Quantity = 50, CreatedDate = DateTime.Now },
         new() { Id = Guid.NewGuid(), Name = "Product 6", Price = 600, Quantity = 60, CreatedDate = DateTime.Now }
        };
        public static List<Product> ProductList => productList;
    }
}