using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class Product
    {
        public int ProductId { get; set; } //PrimaryKey ==> tabeldaki diğer kayıtlardan ayrır.
        public int CategoryId { get; set; } //Foreign Key ==> başka table ile ilişkilendirilmiş
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }

    }
}
