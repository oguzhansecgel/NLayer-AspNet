using Microsoft.EntityFrameworkCore;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository
{
	public class Context : DbContext
	{
        public Context(DbContextOptions<Context> options):base(options) 
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{




			base.OnModelCreating(modelBuilder);
		}
	}
}
