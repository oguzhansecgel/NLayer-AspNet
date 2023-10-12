using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
	public class CategorySeed : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			// seed data veri tohumlama denir. Veri tabanı oluşturulurken ilk sahip olmak istediğimiz verileri bu yöntemle ekleriz.
			
			builder.HasData(new Category { ID = 1, CategoryName = "Kitaplar" },
							new Category {ID=2,CategoryName ="Kalemler" });
		}
	}
}
