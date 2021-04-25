using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 1;
            product1.ProductName = "Masa";
            product1.UnitInStock = 50;
            product1.UnitPrice = 500;

            ProductService productService = new ProductService();
            productService.Add(product1);
            Console.WriteLine(product1.ProductName);

            productService.Update(product1);

            productService.Delete(product1);
        
        }
    }
}
