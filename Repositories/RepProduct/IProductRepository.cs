using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.RepProduct
{
	public interface IProductRepository
	{
		Task<IEnumerable<Product>> GetAll();
	}
}
