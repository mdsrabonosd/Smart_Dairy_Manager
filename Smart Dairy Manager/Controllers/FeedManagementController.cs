using Microsoft.AspNetCore.Mvc;
using Smart_Dairy_Manager.Data;
using Smart_Dairy_Manager.Data_model;

namespace Smart_Dairy_Manager.Controllers
{
    public class FeedManagementController : Controller
    {
        private readonly ApplicationDbContext _Connecton;
        public FeedManagementController(ApplicationDbContext connection)
        {
            _Connecton = connection;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult FoodCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FoodCreate(FeedManagement Srabon)
        {
            var data = _Connecton.FeedManagements.Add(Srabon);
            _Connecton.SaveChanges();
            return View(Srabon);
        }
    }
}
