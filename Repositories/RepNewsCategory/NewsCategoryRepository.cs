using Business;
using Business.Models;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.RepNewsCategory
{
	public class NewsCategoryRepository : INewsCategoryRepository
	{

		public async Task<int> Add(NewsCategory model) => await NewsCategoryDAO.Add(model);

		public async Task<int> DeleteById(int id) => await NewsCategoryDAO.DeleteById(id);

		public async Task<IEnumerable<NewsCategory>> GetAll() => await NewsCategoryDAO.GetAll();

		public async Task<int> Update(NewsCategory model) => await NewsCategoryDAO.Update(model);
	}
}
