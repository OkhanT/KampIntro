using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    //NorthwindContext ==> veritabanındaki tablelarımızla projedeki classlarımızı ilişkilendirir.
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-EG383H8;Database=Northwind;Trusted_Connection=True");
        }

        public DbSet<Product> Products { get; set; }
    }
}
