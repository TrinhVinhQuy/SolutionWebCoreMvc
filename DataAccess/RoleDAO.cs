using Business.Models;
using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
	public class RoleDAO
	{
		public async static Task<int> Add(Role model)
		{
			using (var db = new MyDbContext())
			{
				var check = await db.Role.Where(x => x.Name.Contains(model.Name)).CountAsync();
				if (check < 1)
				{
					_ = db.Role.AddAsync(model);
					db.SaveChanges();
					return 1;
				}
				else
				{
					return 0;
				}
			}
		}
		public async static Task<int> DeleteById(int id)
		{
			using (var db = new MyDbContext())
			{
				var roles = await db.Role.FindAsync(id);
				if (roles != null)
				{
					db.Remove(roles);
					db.SaveChanges();
					return 1;
				}
			}
			return 0;
		}

		public async static Task<IEnumerable<Role>> GetAll()
		{
			using (var db = new MyDbContext())
			{
				var roles = await db.Role.ToListAsync();
				return roles;
			}
		}

		public async static Task<int> Update(Role model)
		{
			using (var db = new MyDbContext())
			{
				var roles = await db.Role.FindAsync(model.Id);
				var rolesName = await db.Role.Where(x => x.Name.Contains(model.Name)).CountAsync();
				if (roles != null && rolesName == 0)
				{
					roles.Name = model.Name;
					db.Update(roles);
					db.SaveChanges();
					return 1;
				}
			}
			return 0;
		}
		public async static Task<IEnumerable<Role>> Pagination(int start, int limit)
		{
			using (var db = new MyDbContext())
			{
				return await db.Role.OrderBy(x => x.Id).Skip(start).Take(limit).ToListAsync();
			}
		}
		public async static Task<int> Total()
		{
			using (var db = new MyDbContext())
			{
				return await db.Role.CountAsync();
			}
		}
		public async static Task<int> numberPage(int limit)
		{
			using (var db = new MyDbContext())
			{
				float number = await db.Role.CountAsync() / limit;
				return (int)Math.Ceiling(number + 1);
			}
		}
	}
}
