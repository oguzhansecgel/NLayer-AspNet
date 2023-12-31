﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Configuration
{
    public class ProductFutureConfig : IEntityTypeConfiguration<ProductFeature>
	{
		public void Configure(EntityTypeBuilder<ProductFeature> builder)
		{
			builder.HasKey(x => x.ID);
			builder.Property(x=>x.ID).UseIdentityColumn();
			builder.HasOne(x => x.Product).WithOne(x => x.ProductFeature).HasForeignKey<ProductFeature>(x => x.ProductID);
		}

	}
}
