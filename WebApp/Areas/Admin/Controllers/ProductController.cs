using Microsoft.AspNetCore.Mvc;
using Repositories.RepProduct;

namespace WebApp.Areas.Admin.Controllers
{
	//[Area("admin")]
	[Route("admin-products")]
	[ApiController]
	public class ProductController : Controller
	{
		private readonly IProductRepository _repository = new ProductRepository();
		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var products = await _repository.GetAll();
			return (IActionResult)products;
			//return Ok(products);
		}
	}
}
