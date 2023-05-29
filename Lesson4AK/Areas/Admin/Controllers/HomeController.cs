using Lesson4AK.Areas.Admin.Models;
using Lesson4AK.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson4AK.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private ProductDBContext _context;

        public HomeController(ProductDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Products()
        {
            var products = _context.Products;
            var models = products.Select(x => new ProductViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price
            });

            return Json(models);
        }
    }
}
