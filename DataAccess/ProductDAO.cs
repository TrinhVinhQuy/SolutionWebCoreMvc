using Business;
using Business.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class ProductDAO
	{
		public async static Task<IEnumerable<Product>> GetAll()
		{
			return null;
		}
	}
}
