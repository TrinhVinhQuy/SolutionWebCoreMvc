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
			using (var db = new MyDbContext())
			{
				var products = await db.Products
   .Include(p => p.ProductCategory) // Tải thông tin ProductCategory của mỗi sản phẩm
   //.Include(p => p.OrdersDetails)    // Tải thông tin OrdersDetails của mỗi sản phẩm
   .Include(p => p.I)           // Tải thông tin Images của mỗi sản phẩm
   .Select(p => new ProductViewModel
   {
	   // ... (các thuộc tính của ProductViewModel)
   })
   .ToListAsync();
				return products;
			}
		}
	}
}
