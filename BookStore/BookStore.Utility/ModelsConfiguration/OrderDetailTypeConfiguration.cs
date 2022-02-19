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
    public class OrderDetailTypeConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(o => new { o.OrderDetailId, o.BookId, o.OrderId }).HasName("PK_OrderHeaderBookOrderId");
            builder.Property(o => o.OrderDetailId).ValueGeneratedOnAdd();
            builder.HasOne(o => o.Book).WithMany(b => b.OrderDetails).HasForeignKey(o => o.BookId).HasConstraintName("FK_OrderDetailBookId");
            builder.HasOne(o => o.OrderHeader).WithMany(o => o.OrderDetails).HasForeignKey(o => o.OrderId).HasConstraintName("FK_OrderDetailOrderId");
        }
    }
}
