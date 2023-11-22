using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
	public class Product
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public int Quantity { get; set; }
		public DateTime? Hot { get; set; }
		public string MetaKeyword { get; set; }
		public string MetaDescription { get; set; }
		public string SeoUrl { get; set; }

		public int ProductCategoryId { get; set; }
		public ProductCategory ProductCategory { get; set; }

		public ICollection<OrdersDetails> ordersDetails { get; set; }
		public ICollection<ProductImage> Images { get; set; }
	}
}
