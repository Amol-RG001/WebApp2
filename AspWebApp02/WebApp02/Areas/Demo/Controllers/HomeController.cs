using Microsoft.AspNetCore.Mvc;
using WebApp02.Areas.Demo.ViewModels;

namespace WebApp02.Areas.Demo.Controllers
{
    [Area("Demo")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Ok("Hello world");
        }

        public IActionResult Index2()
        {
            return View();
        }

        // HTTP GET
        public IActionResult DisplayCustomer()
        {
            CustomerViewModel objModel = new CustomerViewModel()
            {
                CustomerId = 1,
                CreatedOn = System.DateTime.Now
            };
            return View(objModel);
        }

        // HTTP POST
        [HttpPost]
        [ValidateAntiForgeryToken]                      // to address JavaScript Injection Attacks
        public IActionResult DisplayCustomer(
            [Bind("CustomerId,CustomerName,Email,Balance")] CustomerViewModel objModel)
        {
            return View(objModel);
        }

    }
}
