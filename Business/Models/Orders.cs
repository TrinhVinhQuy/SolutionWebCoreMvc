using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
	public class Orders
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int OrdersId { get; set; }
		public DateTime CreateDate { get; set; }
		public string Status { get; set; }
		public string PhoneReceiver { get; set; }
		public string AddressReceiver { get; set; }
		public string NameReceiver { get; set; }
		public int UserId { get; set; }
		public User User { get; set; }
		public ICollection<OrdersDetails> OrdersDetails { get; set; }

	}
}
