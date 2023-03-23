using System;
using Microsoft.EntityFrameworkCore;
using Flint.Controllers;

 namespace Flint.Properties
{
        public class ApplicationContext : DbContext
        {
            public DbSet<Chips> Chipses { get; set; }
            public DbSet<Customer> Customers { get; set; }

            public DbSet<Purchase> Purchases { get; set; }

            protected override void OnConfiguring(
                DbContextOptionsBuilder optionsBuilder
            )
            {
                optionsBuilder
                    .UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog= InterviewTaskDb;");
            }








        }
 }




