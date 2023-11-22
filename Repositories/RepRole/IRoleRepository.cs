using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.RepRole
{
	public interface IRoleRepository
	{
		Task<IEnumerable<Role>> GetAll();
		Task<int> Add(Role model);
		Task<int> Update(Role model);
		Task<int> DeleteById(int id);
		Task<IEnumerable<Role>> Pagination(int start, int limit);
		Task<int> numberPage(int limit);
		Task<int> Total();
	}
}
