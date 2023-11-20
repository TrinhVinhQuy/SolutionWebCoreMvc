using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
	public class ProductCategory
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int CategoryId { get; set; }
		[Required]
		public string CategoryName { get; set; }
		[Required]
		public string MetaKeyword { get; set; }
		[Required]
		public string MetaDescription { get; set; }
		public ICollection<Product> Products { get; set; }
	}
}
