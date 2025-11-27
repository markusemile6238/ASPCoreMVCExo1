using Microsoft.AspNetCore.Mvc;
using VillaAgency.Models.Properties;
using VillaAgency.Models.Properties.Tools;
namespace VillaAgency.Controllers
{
    public class PropertiesController : Controller
    {
        private readonly ILogger<PropertiesController> _logger;

        public PropertiesController(ILogger<PropertiesController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            ViewBag.ActivePage = "Properties";
            var properties = FakePropertiesData.GetSampleProperties();
            ViewBag.EnumType = Enum.GetValues(typeof(PropertieType))    
                .Cast<PropertieType>()
                .Select(p => new {value=p,Name=p.GetDescription()});
            return View(properties);
        }
        public IActionResult Details()
        {
            ViewBag.ActivePage = "Details";
            return View("Details");
        }
    }
}
