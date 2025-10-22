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
            if (Object.VaccinePrice <= 0 || Object.VaccineAgeDay < 0 || Object.VaccineAgeMonth < 0)
            {
                TempData["ErroMsg"] = "Give Input Properly";
                return View(Object);
            }

            var data = _dbconnection.vaccines.Add(Object);
            _dbconnection.SaveChanges();

            Object = new Vaccine();


            return View(Object);


        }

        public IActionResult VaccineList()
        {

            var datalist = _dbconnection.vaccines.Where(x => x.VaccineId != 1 && x.VaccinePrice > 3 || x.VaccinePrice < 100).ToList();

            return View(datalist);
          
        }


        public IActionResult Edit(int id)
        {
            var data = _dbconnection.vaccines.FirstOrDefault(x => x.VaccineId == id);

            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(Vaccine data)
        {

            _dbconnection.vaccines.Update(data);
            _dbconnection.SaveChanges();

            return RedirectToAction("VaccineList");
        }

        public IActionResult Delete(int id)
        {
            var data = _dbconnection.vaccines.FirstOrDefault(x => x.VaccineId == id);

            _dbconnection.vaccines.Remove(data);
            _dbconnection.SaveChanges();

            return RedirectToAction("VaccineList");
        }


        public IActionResult Details(int id)
        {
            var data = _dbconnection.vaccines.FirstOrDefault(x => x.VaccineId == id);

            return View(data);
        }





    }
}
