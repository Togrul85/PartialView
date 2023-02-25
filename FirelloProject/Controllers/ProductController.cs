using FirelloProject.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirelloProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ProductController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            ViewBag.ProductCount = _appDbContext.Products.Count();
            var products = _appDbContext.Products.Include(p => p.ProductImages).Include(p=>p.Category)
                .Take(2).ToList();
            return View(products);
        }
        public IActionResult LoadMore(int skip)
        {
            var products=_appDbContext.Products.Include(p=>p.ProductImages)
                .Include(p=>p.Category)
                .Skip(skip)
                .Take(2)
                .ToList();
            return PartialView("_ProductLoadMorePartial",products);
        }
    }
}
