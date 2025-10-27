using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [HttpGet]
        public IActionResult FoodCreate()
        {
           // Create a fresh empty model when loading the form
            var obj = new FeedManagement();
            return View(obj);
        }

        [HttpPost]
        public IActionResult FoodCreate(FeedManagement Srabon)
        {
         
            if (Srabon.Quantity <= 0)
            {
                TempData["showmassage"] = "Give the Quantity Properly";
                return View(Srabon); 
            }

           
            _Connecton.FeedManagements.Add(Srabon);
            _Connecton.SaveChanges();

            TempData["showmassage"] = "Feed data saved successfully!";

         
            return RedirectToAction(nameof(FoodCreate));
        }

        public IActionResult FoodList()
        {
            var datalist = _Connecton.FeedManagements.ToList();
            return View(datalist);
        }


        public IActionResult Edit(int id)
        {
            var data = _Connecton.FeedManagements.FirstOrDefault(x => x.FeedMGId == id);

            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(FeedManagement data)
        {

            _Connecton.FeedManagements.Update(data);
            _Connecton.SaveChanges();

            return RedirectToAction("FoodList");
        }

        public IActionResult Delete(int id)
        {
            var data = _Connecton.FeedManagements.FirstOrDefault(x => x.FeedMGId == id); 

            _Connecton.FeedManagements.Remove(data);

            _Connecton.SaveChanges();
            
            return RedirectToAction("FoodList");
        }
        public IActionResult Details(int id)
        {
            var srabon = _Connecton.FeedManagements.FirstOrDefault(x =>x.FeedMGId == id);
            return View(srabon);
        }

    }
}
