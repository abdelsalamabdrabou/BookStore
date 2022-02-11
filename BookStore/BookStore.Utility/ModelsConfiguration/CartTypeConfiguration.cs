using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Utility.ModelsConfiguration
{
    public class CartTypeConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(c => c.CartId).HasName("PK_CartId");
            builder.HasOne(c => c.Book).WithMany(b => b.Carts).HasForeignKey(c => c.BookId).HasConstraintName("FK_BookId");
            builder.HasOne(c => c.User).WithMany(u => u.Carts).HasForeignKey(c => c.UserId).HasConstraintName("FK_UserId");
            builder.Property(c => c.CartId).ValueGeneratedOnAdd();
            builder.Property(c => c.Count).IsRequired();
        }
    }
}
