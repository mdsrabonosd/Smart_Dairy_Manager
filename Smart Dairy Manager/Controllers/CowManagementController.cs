using Microsoft.AspNetCore.Mvc;
using Smart_Dairy_Manager.Data;
using Smart_Dairy_Manager.Data_model;

namespace Smart_Dairy_Manager.Controllers
{
  
    public class CowManagementController : Controller
    {
        private readonly ApplicationDbContext _Dbcontext;
        public CowManagementController(ApplicationDbContext dbcontext)
        {
            _Dbcontext = dbcontext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CowList()
        {
            var datalist = _Dbcontext.Cows.ToList();
            return View(datalist);
        }


        //public IActionResult VaccineList()
        //{

        //    var datalist = _dbconnection.vaccines.Where(x => x.VaccineId != 1 && x.VaccinePrice > 3 || x.VaccinePrice < 100).ToList();

        //    return View(datalist);
        //}




        [HttpGet]
        public IActionResult Create()
        {
            var obj = new Cow();


            return View(obj);
        }


        [HttpPost]

        public IActionResult Create(Cow Object)
        {
            if (Object.Price <= 0 || Object.Weight< 0 )
            {
                TempData["srabonmsg"] = "Give Input Properly";
                return View(Object);
            }

            var data = _Dbcontext.Cows.Add(Object);
           _Dbcontext.SaveChanges();
            Object = new Cow();

            return View(Object);
        }
    }
}

