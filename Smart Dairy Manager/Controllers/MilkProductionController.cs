using Microsoft.AspNetCore.Mvc;
using Smart_Dairy_Manager.Data;
using Smart_Dairy_Manager.Data_model;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            var data = _Dbconnection.MilkCollections.ToList();
            return View(data);
        }

        public IActionResult Edit(int id)
        {
            var data = _Dbconnection.MilkCollections.FirstOrDefault(x => x.MilkCollectionId == id);
            return View(data);
        }


        [HttpPost]
        public IActionResult Edit(MilkCollection obj)
        {
            _Dbconnection.MilkCollections.Update(obj);
            _Dbconnection.SaveChanges();
            return RedirectToAction("MilkList");
        }

        public IActionResult Delete( int id)
        {
            var item = _Dbconnection.MilkCollections.FirstOrDefault(x => x.MilkCollectionId == id);
            _Dbconnection.MilkCollections.Remove(item);
            _Dbconnection.SaveChanges();
             return RedirectToAction("MilkList");
        }
        public IActionResult Details(int id )
        {
            var data = _Dbconnection.MilkCollections.FirstOrDefault(x => x.MilkCollectionId == id);
            return View(data);
        }
    }
}
