using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
	public class News
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string Name { get; set; }
		public string MetaKeyword { get; set; }
		public string MetaDescription { get; set; }
		public string SeoUrl { get; set; }
		public int NewsCategoryId { get; set; }
		public NewsCategory NewsCategory { get; set; }
		public int UserId { get; set; }
		public User User { get; set; }
	}
}
