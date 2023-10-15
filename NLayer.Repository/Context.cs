using Microsoft.EntityFrameworkCore;
using NLayer.Core.Models;
using NLayer.Repository.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository
{
    public class Context : DbContext
	{
        public Context(DbContextOptions<Context> options):base(options) 
        {
            
        }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=DESKTOP-3QG9GTV;initial catalog = NLayerProje; integrated security=true");
		}
		public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Kullanım türü fakat 10-15'den fazla entity olduğunu düşünürsek metodu kullanmak zahmetli
			//modelBuilder.ApplyConfiguration(new ProductConfig());
			//modelBuilder.ApplyConfiguration(new CategoryConfig());
			

			// fakat burda assemblyde bütün interfaceleri bulur ve uygular. 
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


			base.OnModelCreating(modelBuilder);
		}
	}
}
