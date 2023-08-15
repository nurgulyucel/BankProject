using Microsoft.AspNetCore.Mvc;

namespace BankUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
    }
}
