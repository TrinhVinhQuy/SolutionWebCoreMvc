using Business.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories.RepNewsCategory;

namespace WebApp.Areas.Admin.Controllers
{
	[Area("admin")]
	[Route("admin-news-category")]
	public class NewsCategoryController : Controller
	{
		private readonly INewsCategoryRepository _newsCategoryRepository = new NewsCategoryRepository();
		public async Task<IActionResult> Index()
		{
			var newCate = await _newsCategoryRepository.GetAll();
			return View(newCate);
		}
		[HttpPost]
		public async Task<IActionResult> Index(NewsCategory model)
		{
			string status = Convert.ToString(HttpContext.Request.Query["status"]);
			if (HttpContext.Request.Query["id"] != "")
			{
				model.Id = Convert.ToInt32(HttpContext.Request.Query["id"]);
			}
			if (HttpContext.Request.Query["name"] != "")
			{
				model.Name = Convert.ToString(HttpContext.Request.Query["name"]);
			}
			switch (status)
			{
				case "update":
					if (await _newsCategoryRepository.Update(model) == 1)
					{
						return RedirectToAction("Index");
					}
					return RedirectToAction("Index");
				case "add":
					if (await _newsCategoryRepository.Add(model) == 1)
					{
						return RedirectToAction("Index");
					}
					else
					{
						TempData["Fail"] = "Tiêu đề đã trùng";
						return RedirectToAction("Index");
					}
				case "delete":
					if (await _newsCategoryRepository.DeleteById(Convert.ToInt32(HttpContext.Request.Query["id"])) == 1)
					{
						return RedirectToAction("Index");
					}
					return RedirectToAction("Index");
				default:
					return RedirectToAction("Index");
			}
		}
	}
}
