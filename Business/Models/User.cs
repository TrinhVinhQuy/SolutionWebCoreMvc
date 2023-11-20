using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
	public class User
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int UserId { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Address { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public bool Status { get; set; }
		public int RoleId { get; set; }
		public Role Role { get; set; }
	}
}
