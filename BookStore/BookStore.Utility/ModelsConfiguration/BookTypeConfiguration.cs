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
    public class BookTypeConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => new { b.BookId, b.ISBN });
            builder.HasOne(b => b.Category).WithMany(c => c.Books).HasForeignKey(b => b.CategoryId).HasConstraintName("FK_CategoryId");
            builder.Property(b => b.BookId).ValueGeneratedOnAdd();
            builder.Property(b => b.Author).IsRequired();
            builder.Property(b => b.Description).IsRequired();
            builder.Property(b => b.Edition).IsRequired();
            builder.Property(b => b.ISBN).IsRequired();
            builder.Property(b => b.Title).IsRequired();
            builder.Property(b => b.PurchasePrice).IsRequired();
            builder.Property(b => b.Publisher).IsRequired();
            builder.Property(b => b.PublicationYear).IsRequired();
        }
    }
}
