using Business.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.RepRole
{
	public class RoleRepository : IRoleRepository
	{
		public Task<int> Add(Role model) => RoleDAO.Add(model);
		public Task<int> DeleteById(int id) => RoleDAO.DeleteById(id);
		public Task<IEnumerable<Role>> GetAll() => RoleDAO.GetAll();
		public Task<int> numberPage(int limit) => RoleDAO.numberPage(limit);
		public async Task<IEnumerable<Role>> Pagination(int start, int limit) => await RoleDAO.Pagination(start, limit);
		public async Task<int> Total() => await RoleDAO.Total();
		public async Task<int> Update(Role model) => await RoleDAO.Update(model);
	}
}
