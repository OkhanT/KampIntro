using System;
using System.Linq;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ADO.NET ==> Veri tabanına bağlanmamızı, kontrol etmemizi, sorgu yazmamızı sağlayan bir kütüphanedir.(library) Bu library vasıtasıyla verilerimizi ekleyebilir, listeleyebilir ve güncelleyebiliriz. Ancak günümüzde ADO.NET le kod yazmak biraz yorucudur. Bu yüzden bu sürecleri kolaylaştırma ve proje classlarımızla veritabanı ilişkisi sağlamak ve kolaylaştırmak adına çeşitli ORM dediğimiz yapıları kullanırız. 
            //ORM - Object Relational Mapping - Nesne ilişkisel İşaretleme 
            //ORM yapısını kullanmamızı sağlayan Entity Frameworktür.
            //Entity Framework alternatifleride vardır. Bir tanesi NHibernate
            //Microsoft .NetCore güncellemesinden sonra Entity Framework ü çok iyi hale getirmiştir.
            //Dapper ORM olmaktan ziyade ADO.NET in kolaylaştırılmış halidir.


            //GetAll();
            GetProductsByCategory(3);
        }

        private static void GetAll()
        {
            NorthwindContext context = new NorthwindContext();
            foreach (var product in context.Products)
            {
                Console.WriteLine(product.ProductName);
            }
        }


        private static void GetProductsByCategory(int categoryId)
        {
            NorthwindContext context = new NorthwindContext();
            var result = context.Products.Where(p=>p.CategoryId==categoryId).ToList();
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
            
        }
    }
}
