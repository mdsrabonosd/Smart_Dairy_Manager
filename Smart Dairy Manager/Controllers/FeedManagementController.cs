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
        public IActionResult FoodList()
        {
            var datalist = _Connecton.FeedManagements.ToList();
            return View(datalist);
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
            // Validation check
            if (Srabon.Quantity <= 0)
            {
                TempData["showmassage"] = "Give the Quantity Properly";
                return View(Srabon); // Keep old input values
            }

            // Save valid data
            _Connecton.FeedManagements.Add(Srabon);
            _Connecton.SaveChanges();

            // Success message
            TempData["showmassage"] = "Feed data saved successfully!";

            // Redirect to clear the form
            return RedirectToAction(nameof(FoodCreate));
        }
    }
}
//ই কন্ট্রোলারে দুটি কাজ ঠিক করা হয়েছে:

//ভুল ইনপুট(Quantity <= 0) দিলে
//→ return View(Srabon); দেয়, তাই আগের ইনপুট ফর্মে থাকবে।

//সঠিক ইনপুট দিলে
//→ ডেটা সেভ হয়, তারপর RedirectToAction("FoodCreate") দিয়ে
//ফর্ম একদম নতুনভাবে খুলে যায় (খালি ফর্ম)।
