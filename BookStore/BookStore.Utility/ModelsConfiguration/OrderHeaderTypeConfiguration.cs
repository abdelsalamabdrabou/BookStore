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
    public class OrderHeaderTypeConfiguration : IEntityTypeConfiguration<OrderHeader>
    {
        public void Configure(EntityTypeBuilder<OrderHeader> builder)
        {
            builder.HasKey(o => o.OrderId).HasName("PK_OrderId");
            builder.Property(o => o.OrderId).ValueGeneratedOnAdd();
            builder.HasOne(o => o.User).WithMany(u => u.OrderHeaders).HasForeignKey(o => o.UserId).HasConstraintName("FK_UserIdOrderId");
            builder.Property(o => o.PhoneNumber).IsRequired();
            builder.Property(o => o.Street).IsRequired();
            builder.Property(o => o.City).IsRequired();
            builder.Property(o => o.State).IsRequired();
            builder.Property(o => o.Zip).IsRequired();
        }
    }
}
