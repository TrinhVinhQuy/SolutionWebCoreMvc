using Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
	public class MyDbContext : DbContext
	{
		public MyDbContext() { }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json", true, true);
			IConfiguration configuration = builder.Build();
			optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyDBContext"));
		}
		public DbSet<Product> Products { get; set; }
		public DbSet<ProductCategory> ProductCategories { get; set; }
		public DbSet<OrdersDetails> OrdersDetails { get; set; }
		public DbSet<Orders> Orders { get; set; }
		public DbSet<News> News { get; set; }
		public DbSet<NewsCategory> NewsCategories { get; set; }
		public DbSet<ProductImage> ProductImages { get; set; }
		public DbSet<User> User { get; set; }
		public DbSet<Role> Role { get; set; }
		public object NewsCategorys { get; set; }
	}
}
