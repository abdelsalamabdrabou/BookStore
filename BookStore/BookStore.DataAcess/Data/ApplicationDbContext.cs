using BookStore.Models;
using BookStore.Utility.ModelsConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
               
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            new CategoryTypeConfiguration().Configure(builder.Entity<Category>());
            new BookTypeConfiguration().Configure(builder.Entity<Book>());
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }

    }
}
