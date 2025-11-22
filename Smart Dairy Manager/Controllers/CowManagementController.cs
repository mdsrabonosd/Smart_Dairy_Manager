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

        [HttpGet]
        public IActionResult Create()
        {
            var obj = new Cow();


            return View(obj);
        }


        [HttpPost]

        public IActionResult Create(Cow Object)
        {
            if (Object.Price <= 0 || Object.Weight < 0)
            {
                TempData["srabonmsg"] = "Give Input Properly";
                return View(Object);
            }

            var data = _Dbcontext.Cows.Add(Object);
            _Dbcontext.SaveChanges();
            Object = new Cow();

            return RedirectToAction("CowList");
        }


        public IActionResult CowList()
        {
            var datalist = _Dbcontext.Cows.ToList();
            return View(datalist);
        }

        public IActionResult Edit(int id)
        {
            var data = _Dbcontext.Cows.FirstOrDefault(x => x.CowId == id);

            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(Cow data)
        {

            _Dbcontext.Cows.Update(data);
            _Dbcontext.SaveChanges();

            return RedirectToAction("CowList");
        }

        [HttpPost]
        public IActionResult Delete(int ID)
        {
            if (ID <= 0)
            {
                return Json("id not valid");
            }
            var data = _Dbcontext.Cows.FirstOrDefault(x=>x.CowId==ID);
            if (data != null)
            {
                _Dbcontext.Cows.Remove(data);
                _Dbcontext.SaveChanges();
                return Json("ok");
            }
            return BadRequest();
        }

        public IActionResult Details(int id)
        {
            var data = _Dbcontext.Cows.FirstOrDefault(x => x.CowId == id);

            return View(data);
        }


    }
}

