using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
	public class OrdersDetails
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int OrdersDetailsId { get; set; }
		public int Quantity { get; set; }
		public decimal PriceNow { get; set; }
		public int ProductId { get; set; }
		public Product Product { get; set; }
		public int OrdersId { get; set; }
		public Orders Orders { get; set; }
	}
}
