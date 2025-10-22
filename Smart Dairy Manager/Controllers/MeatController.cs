using Microsoft.AspNetCore.Mvc;
using Smart_Dairy_Manager.Data;
using Smart_Dairy_Manager.Data_model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Smart_Dairy_Manager.Controllers
{
    public class MeatController : Controller
    {
        private readonly ApplicationDbContext _dbconnection;
        public MeatController(ApplicationDbContext dbconnection)
        {
            _dbconnection = dbconnection;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MeatCreate()
        {

            return View();

        }
        [HttpPost]
        public IActionResult MeatCreate(MeatProduction srabon)
        {
            if (srabon.CowWeight <= 0)
            {
                TempData["srabonmsge"] = "Give input properly";
                return View(srabon);
            }
            var data = _dbconnection.MeatProductions.Add(srabon);
            _dbconnection.SaveChanges();
            return RedirectToAction(nameof(MeatCreate));

        }
        public IActionResult MeatProductionList()
        {
            var datalist = _dbconnection.MeatProductions.ToList();

            return View(datalist);
        }


        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete(int id)
        {
            var data = _dbconnection.MeatProductions.FirstOrDefault(x => x.MeatProductionId == id);
            _dbconnection.MeatProductions.Remove(data);
            _dbconnection.SaveChanges();

            return RedirectToAction("MeatProductionList");
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
