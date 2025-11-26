using Microsoft.AspNetCore.Mvc;

namespace VillaAgency.Controllers
{
    public class ContactController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
