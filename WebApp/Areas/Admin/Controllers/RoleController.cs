using Business.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories.RepRole;

namespace WebApp.Areas.Admin.Controllers
{
	[Area("admin")]
	[Route("admin-roles")]
	public class RoleController : Controller
	{
		private readonly IRoleRepository _roleRepository = new RoleRepository();
		public async Task<IActionResult> Index(int? page = 0)
		{
			int limit = 3;
			int start;
			page = page > 0 ? page : 1;
			start = (int)(page-1) * limit;
			ViewBag.pageCurrent = page;
			ViewBag.total = await _roleRepository.Total();
			ViewBag.numberPage = await _roleRepository.numberPage(limit);
			var data = await _roleRepository.Pagination(start, limit);
			return View(data);

		}
		[HttpPost]
		public async Task<IActionResult> Index(Role model)
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
					if (await _roleRepository.Update(model) == 1)
					{
						return RedirectToAction("Index");
					}
					else
					{
						TempData["Fail"] = "Quyền đã tồn tại!";
						return RedirectToAction("Index");
					}
				case "add":
					if (await _roleRepository.Add(model) == 1)
					{
						return RedirectToAction("Index");
					}
					else
					{
						TempData["Fail"] = "Quyền đã tồn tại!";
						return RedirectToAction("Index");
					}
				case "delete":
					if (await _roleRepository.DeleteById(Convert.ToInt32(HttpContext.Request.Query["id"])) == 1)
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
