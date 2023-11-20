﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
	public class ProductImage
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int PrImgaeId { get; set; }
		public string Image { get; set; }
		public int ProductId { get; set; }
		public Product Product { get; set; }
	}
}
