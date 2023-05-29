using Lesson4AK.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace Lesson4AK.ViewComponents
{
    public class CategoryListViewComponent : ViewComponent
    {
        private readonly ProductDBContext _context;

        public CategoryListViewComponent(ProductDBContext context)
        {
            _context = context;
        }

        public ViewViewComponentResult Invoke(string filter="")
        {
            return View(
                new CategoryListViewModel
                {
                    Categories = (string.IsNullOrEmpty(filter))? _context.Categories.ToList()
                    :_context.Categories.Where(c=>c.Title.ToLower().Contains(filter.ToLower())).ToList()
                }
                );
        }
    }
}
