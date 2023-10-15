using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Configuration
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.HasKey(x => x.ID);
			builder.Property(x => x.ID).UseIdentityColumn();
			builder.Property(x => x.ProductName).IsRequired().HasMaxLength(200);
			builder.Property(x => x.Stock).IsRequired();

			builder.Property(x=>x.Price).IsRequired().HasColumnType("decimal(10,2)");
			builder.ToTable("PRODUCT");

			// birden çoğa ilişki - bir category birden fazla ürüne sahip olabilir fakat bir ürünün bir category si olabilir.
			builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryID);
		}
	}
}
