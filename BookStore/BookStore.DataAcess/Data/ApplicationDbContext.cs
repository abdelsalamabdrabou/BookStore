using BookStore.Models;
using BookStore.Utility.ModelsConfiguration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
               
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            new CategoryTypeConfiguration().Configure(builder.Entity<Category>());
            new BookTypeConfiguration().Configure(builder.Entity<Book>());
            new CartTypeConfiguration().Configure(builder.Entity<Cart>());
            new OrderHeaderTypeConfiguration().Configure(builder.Entity<OrderHeader>());
            new OrderDetailTypeConfiguration().Configure(builder.Entity<OrderDetail>());
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

    }
}
