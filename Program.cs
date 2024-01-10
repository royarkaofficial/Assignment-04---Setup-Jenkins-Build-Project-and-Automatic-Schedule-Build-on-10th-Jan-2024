using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatic_Build
{
    class Product
    {
        public string PName { get; set; }
        public decimal PPrice { get; set; }
        public string PBrand { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpiryDate { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var productList = new List<Product>
        {
            new Product
            {
                PName = "Product1",
                PPrice = 19.99m,
                PBrand = "BrandA",
                ManufacturingDate = DateTime.Parse("2023-01-15"),
                ExpiryDate = DateTime.Parse("2023-12-31")
            },
            new Product
            {
                PName = "Product2",
                PPrice = 25.50m,
                PBrand = "BrandB",
                ManufacturingDate = DateTime.Parse("2022-12-01"),
                ExpiryDate = DateTime.Parse("2023-11-30")
            },
            new Product
            {
                PName = "Product3",
                PPrice = 15.75m,
                PBrand = "BrandC",
                ManufacturingDate = DateTime.Parse("2023-02-10"),
                ExpiryDate = DateTime.Parse("2023-10-31")
            },
            new Product
            {
                PName = "Product4",
                PPrice = 30.00m,
                PBrand = "BrandA",
                ManufacturingDate = DateTime.Parse("2023-03-05"),
                ExpiryDate = DateTime.Parse("2023-09-30")
            },
            new Product
            {
                PName = "Product5",
                PPrice = 22.99m,
                PBrand = "BrandB",
                ManufacturingDate = DateTime.Parse("2023-04-20"),
                ExpiryDate = DateTime.Parse("2023-08-31")
            }
        };

            DisplayProductDetails(productList);
        }
        static void DisplayProductDetails(List<Product> productList)
        {
            Console.WriteLine($"{"Index Key",-10}{"PName",-20}{"Price",-10}{"Brand",-15}{"MfDate",-20}{"ExpDate"}");

            for (var i = 0; i < productList.Count; i++)
            {
                var product = productList[i];
                Console.WriteLine($"{i,-10}{product.PName,-20}{product.PPrice,-10}{product.PBrand,-15}{product.ManufacturingDate,-20}{product.ExpiryDate}");
            }
        }
    }
}