using Microsoft.AspNetCore.Mvc;
using Smart_Dairy_Manager.Data;
using Smart_Dairy_Manager.Data_model;

namespace Smart_Dairy_Manager.Controllers
{
    public class VaccineController : Controller
    {
        private readonly ApplicationDbContext _dbconnection;
        public VaccineController(ApplicationDbContext db_connection)
        {
            _dbconnection = db_connection;

        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult VaccineCreate()
        {
            var obj = new Vaccine();
            return View(obj);

        }

        [HttpPost]
        public IActionResult VaccineCreate(Vaccine Object)
        {
            if (Object.VaccinePrice <= 0 || Object.VaccineAgeDay<0 || Object.VaccineAgeMonth < 0)
            {
                TempData["ErroMsg"] = "Give Input Properly";
                return View(Object);
            }

            var data = _dbconnection.vaccines.Add(Object);
            _dbconnection.SaveChanges();
            return View(Object);


        }



    }
}
