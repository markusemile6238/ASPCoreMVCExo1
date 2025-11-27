using Microsoft.AspNetCore.Mvc;

namespace VillaAgency.Controllers
{
    public class ContactController : Controller
    {
        private readonly ILogger<ContactController> _logger;

        public ContactController(ILogger<ContactController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            ViewBag.ActivePage = "Contact";
            return View();
        }
    }
}
