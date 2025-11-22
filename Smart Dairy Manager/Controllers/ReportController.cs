using Microsoft.AspNetCore.Mvc;

namespace Smart_Dairy_Manager.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 
        public IActionResult dairyreport()
        {
            return View();
        }
    }
}
