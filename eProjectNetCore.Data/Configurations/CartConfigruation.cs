using eProjectNetCore.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eProjectNetCore.Data.Configurations
{
    public class CartConfigruation : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Carts");
            builder.HasAlternateKey(s => s.Id);
            builder.Property(s => s.Id).UseIdentityColumn();

            builder.HasOne(s => s.Product).WithMany(s => s.Carts).HasForeignKey(s => s.ProductId);
            builder.HasOne(x => x.AppUser).WithMany(x => x.Carts).HasForeignKey(x => x.UserId);

        }
    }
}
