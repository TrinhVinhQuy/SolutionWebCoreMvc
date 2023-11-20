using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.RepNewsCategory
{
	public interface INewsCategoryRepository
	{
		Task<IEnumerable<NewsCategory>> GetAll();
		Task<int> Add(NewsCategory model);
		Task<int> Update(NewsCategory model);
		Task<int> DeleteById(int id);
	}
}
