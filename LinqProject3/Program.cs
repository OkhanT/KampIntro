using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject3
{
    class Program
    {
        //birden fazla list'in birleştirilmesi
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
            //ClassicLinqTest(products);

            //CategoryName alabilmek için Join kullanırız ;

            var result = from p in products
                         join c in categories
                on p.CategoryId equals c.CategoryId
                         select new ProductDto {ProductId=p.ProductId,CategoryName=c.CategoryName,ProductName=p.ProductName, UnitPrice=p.UnitPrice};

            foreach (var productDto in result)
            {
                Console.WriteLine(productDto.ProductName + " " + productDto.CategoryName);
            }
            Console.WriteLine("-----------------");
            
            //ikinci yazım tekniği

            var result2 = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         select new ProductDto { ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitPrice };

            foreach (var productDto in result2)
            {
                //"{0} {1}" kullanımı ==> string interpolation 
                Console.WriteLine("{0} --- {1}", productDto.ProductName, productDto.CategoryName);
            }
            
            Console.WriteLine("-------------------");
                      
            //join nin örnekleri -- Join - Where kullanımı
            var result3 = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         where p.UnitPrice>5000
                         select new ProductDto { ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitPrice };
            foreach (var productDto in result3)
            {
                Console.WriteLine("{0}---{1}", productDto.ProductName, productDto.CategoryName);
            }

            Console.WriteLine("---------");
            //Join--Where--OrderBy kullanımı

            var result4 = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         where p.UnitPrice > 5000
                         orderby p.UnitPrice descending
                         select new ProductDto { ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitPrice };
            foreach (var productDto in result4)
            {
                Console.WriteLine("{0}---{1}",productDto.ProductName,productDto.CategoryName);
            }

        }

        private static void ClassicLinqTest(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 5000
                         orderby p.UnitPrice descending, p.UnitPrice ascending
                         select p.ProductName;

            foreach (var product in result)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine("---------------");

            var result2 = from p in products
                          where p.UnitPrice > 5000
                          orderby p.UnitPrice descending, p.ProductName ascending
                          select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice };

            foreach (var product in result2)
            {
                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine("---------------");
        }
    }

    class ProductDto
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
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
