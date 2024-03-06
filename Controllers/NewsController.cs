using Microsoft.AspNetCore.Mvc;
using ShopSG2.DataContext;

namespace ShopSG2.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult News()
        {
            return View("News",ApplicationContext.productShops);
        }
    }
}
