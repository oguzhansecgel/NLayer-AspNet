using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Configuration
{
	public class CategoryConfig : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.HasKey(x => x.ID);
			builder.Property(x=>x.ID).UseIdentityColumn();
			builder.Property(x => x.CategoryName).IsRequired().HasMaxLength(50);
			builder.ToTable("CATEGORIES");
		}
	}
}
