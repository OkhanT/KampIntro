using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
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
                new Product{ProductId=3,CategoryId=1,ProductName="Hp Laptop", QuantityPerUnit="8 GB Ram",UnitPrice=6000,UnitInStock=2},
                new Product{ProductId=4,CategoryId=2,ProductName="Samsung Telefon",QuantityPerUnit="4 GB Ram",UnitPrice=5000,UnitInStock=15},
                new Product{ProductId=5,CategoryId=2,ProductName="Apple Telefon",QuantityPerUnit="4 GB Ram",UnitPrice=8000,UnitInStock=0 }
            };

            //Test(products);

            //Get1Products(products);
            //GetProducts(products);
            //AnyTest(products);
            //FindTest(products);
            //FindAllTest(products);
            //WhereTest(products);
            //OrderByTest(products);
            //ThenByTest(products);
            
        }

        private static void ThenByTest(List<Product> products)
        {
            //ThenBy ın default u Ascending dir. Ascending = Artan 
            var result = products.Where(p => p.ProductName.Contains("fon")).OrderByDescending(p => p.UnitPrice).ThenBy(p => p.ProductName);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

            //ThenByDescending. Descending = Düşen 
            var result2 = products.Where(p => p.ProductName.Contains("fon")).OrderByDescending(p => p.UnitPrice).ThenByDescending(p => p.ProductName);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void OrderByTest(List<Product> products)
        {
            //OrderBy ın defaultu Ascending dir.. Ascending = Artan 
            var result = products.Where(p => p.ProductName.Contains("top")).OrderBy(p => p.UnitPrice);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

            //OrderByDescending ==> Descending = Düşen-Azalan
            var result2 = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice);
            foreach (var product in result2)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void WhereTest(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("top"));
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.CategoryId == 1);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

            var result2 = products.FindAll(p => p.ProductName.Contains("top"));
            foreach (var product in result2)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindTest(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result.ProductName);
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Acer Laptop");
            Console.WriteLine(result);

            var result2 = products.Any(p => p.ProductName == "Dell Laptop");
            Console.WriteLine(result2);
        }

        private static void Test(List<Product> products)
        {
            Console.WriteLine("-----Linq kullanmadan standart kad ile veri çekme yolları---- ");

            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine("---------------------------- ");
            //fiyatı 5000 üzerinde olanları gösterme;
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            Console.WriteLine("---------------------------- ");
            //fiyatı 5000 üzeri olan ve stoğu 5 den fazla olanları
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            Console.WriteLine("************************************");
            Console.WriteLine("-------------Linq Kullanarak veri çekme--------------- ");
            //fiyatı 5000 üzerinde olanları gösterme;
            var result = products.Where(p => p.UnitPrice > 5000);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine("---------------------------- ");
            //fiyatı 5000 üzeri olan ve stoğu 5 den fazla olanları
            var result2 = products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3);
            foreach (var product in result2)
            {
                Console.WriteLine(product.ProductName);
            }
            Console.WriteLine("---------------------------- ");
        }


        //Link siz foksiyonla veri çekme
        static List<Product> Get1Products(List<Product> products)
        {
            List<Product> filteredProduct = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitInStock > 3)
                {
                    filteredProduct.Add(product);
                }
            }
            return filteredProduct;
        }



        //bir fonksionda Linq kullanarak veri çekme
        static List<Product> GetProducts(List<Product> products)
        {
            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitInStock > 3).ToList();
            return result;
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
