using Microsoft.AspNetCore.Mvc;
using Smart_Dairy_Manager.Data;
using Smart_Dairy_Manager.Data_model;

namespace Smart_Dairy_Manager.Controllers
{
    public class MilkProductionController : Controller
    {
        private readonly ApplicationDbContext _Dbconnection;
        public MilkProductionController(ApplicationDbContext Dbconnection)
        {
            _Dbconnection = Dbconnection; 
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MilkCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MilkCreate(MilkCollection Object)
        {
          var data= _Dbconnection.MilkCollections.Add(Object);
            _Dbconnection.SaveChanges();    

            return RedirectToAction("MilkCreate");
        }

        public IActionResult MilkList()
        {
            return View();
        }
    }
}
