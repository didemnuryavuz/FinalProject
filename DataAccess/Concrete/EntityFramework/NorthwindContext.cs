using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : Db tabloları ile proje classlarını bağlar
    public class NorthwindContext : DbContext
    {
        //Bu method senin projen hangi Db ilişkiliyi getirir.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Sql Server'ın ip girilir.@ -> \ alakalıdır.
            //Sql adı,database adı,kullanıcı adı olmadan.
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-3TFCDKG\MSSQLSERVER1;Database=Northwind;Trusted_Connection=true");
        }
        //Hangi nesne hangisine karşılık gelecek
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}
