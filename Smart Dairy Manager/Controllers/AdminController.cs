using Microsoft.AspNetCore.Mvc;

namespace Smart_Dairy_Manager.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
