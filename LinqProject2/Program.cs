using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject2
{
    class Program
    {
        //Tek bir list üzerinde veri sorgulama
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Bilgisayar"},
                new Category{CategoryId=2, CategoryName="Telefon"}
            };

            List<Product> products = new List<Product>()
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Acer Laptop", QuantityPerUnit="32 GB Ram", UnitPrice=10000,UnitInStock=5},
                new Product{ProductId=2,CategoryId=1,ProductName="Asus Laptop", QuantityPerUnit="16 GB Ram", UnitPrice=18000,UnitInStock=3},
                new Product{ProductId=3,CategoryId=1,ProductName="Hp Laptop", QuantityPerUnit="8 GB Ram",UnitPrice=18000,UnitInStock=2},
                new Product{ProductId=4,CategoryId=2,ProductName="Samsung Telefon",QuantityPerUnit="4 GB Ram",UnitPrice=5000,UnitInStock=15},
                new Product{ProductId=5,CategoryId=2,ProductName="Apple Telefon",QuantityPerUnit="4 GB Ram",UnitPrice=8000,UnitInStock=0 }
            };

            //Linq in ikinci kullanım teknikleri;
            var result = from p in products
                         select p;
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("-------------------");

            var result2 = from p in products
                          where p.UnitPrice>6000
                         select p;

            foreach (var product in result2)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("------------------");
            //orderby ın defaultu ascendingdir. ascending = artan
            var result3 = from p in products
                         where p.UnitPrice > 5000
                         orderby p.UnitPrice
                         select p;
            foreach (var product in result3)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("-------------");
            //descending = düşen-azalan
            var result4 = from p in products
                         where p.UnitPrice > 5000
                         orderby p.UnitPrice descending
                         select p;
            foreach (var product in result4)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("-------------");
            var result5 = from p in products
                          where p.UnitPrice > 5000
                          orderby p.UnitPrice descending, p.ProductName ascending
                          select p;
            foreach (var product in result5)
            {
                Console.WriteLine(product.ProductName);
            }
        
        
        
        }
    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
