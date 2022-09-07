using Batch1_DET_2022.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022.Data
{
    public class BookContext : DbContext
    {
        public BookContext()
        {
        }
        public BookContext(DbContextOptions<BookContext> options)
        : base(options)
        {
        }
        //public virtual DbSet<Book> Book { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=H9B4N62-SHEL\\SQLEXPRESS;Database=learningtsql;Trusted_Connection=True;MultipleActiveResultSets=True");

            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Book>()
            //        .Property(b => b.price)
            //        .IsRequired()
            //        .HasColumnName("Bkprice")
            //        .HasDefaultValue(200);
        }
    }
}
