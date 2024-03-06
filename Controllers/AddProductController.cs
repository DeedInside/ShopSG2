using Microsoft.AspNetCore.Mvc;
using ShopSG2.DataContext;
using ShopSG2.Model;

namespace ShopSG2.Controllers
{
    public class AddProductController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult AddProd(string Name, string Description, string Price) 
        {
            ApplicationContext.ListProducts.Add(
                new Product(
                    Name,
                    Description,
                    Convert.ToDouble(Price),
                    "Default")
            );

            return View("Add");
        }
    }
}
