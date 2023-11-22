using Business.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.RepProduct
{
	public class ProductRepository : IProductRepository
	{
		public async Task<IEnumerable<Product>> GetAll() => await ProductDAO.GetAll();
	}
}
