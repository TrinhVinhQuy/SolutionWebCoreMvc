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
	public class NewsCategoryDAO
	{
		public async static Task<int> Add(NewsCategory model)
		{
			using (var db = new MyDbContext())
			{
				var check = await db.NewsCategories.Where(x => x.Name.Contains(model.Name)).CountAsync();
				if (check < 1)
				{
					_ = db.NewsCategories.AddAsync(model);
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
				var newcate = await db.NewsCategories.FindAsync(id);
				if (newcate != null)
				{
					db.Remove(newcate);
					db.SaveChanges();
					return 1;
				}
			}
			return 0;
		}

		public async static Task<IEnumerable<NewsCategory>> GetAll()
		{
			using (var db = new MyDbContext())
			{
				var newcates = await db.NewsCategories.ToListAsync();
				return newcates;
			}
		}

		public async static Task<int> Update(NewsCategory model)
		{
			using (var db = new MyDbContext())
			{
				var newcate = await db.NewsCategories.FindAsync(model.Id);
				if (newcate != null)
				{
					newcate.Name = model.Name;
					db.Update(newcate);
					db.SaveChanges();
					return 1;
				}
			}
			return 0;
		}
	}
}
