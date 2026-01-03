using Microsoft.AspNetCore.Mvc;
using Smart_Dairy_Manager.Data;
using Smart_Dairy_Manager.Data_model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Smart_Dairy_Manager.Controllers
{
    public class VaccineApplyController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public VaccineApplyController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ApplyCreate()
        {
            return View();
        }
        [HttpPost]

        public IActionResult ApplyCreate(VaccineApply obj)
        {
            var data = _dbContext.VaccineApplies.Add(obj);
            _dbContext.SaveChanges();
            return RedirectToAction("ApplyCreate");
        }
        public IActionResult ApplyList()
        {
            var data = _dbContext.VaccineApplies.ToList();

            return View(data);
        }

        public IActionResult Edit(int id)
        {
            var data = _dbContext.VaccineApplies
                        .FirstOrDefault(x => x.VaccineApplyId == id);

            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(VaccineApply obj)
        {
            _dbContext.VaccineApplies.Update(obj);
            _dbContext.SaveChanges();

            return RedirectToAction("ApplyList");
        }

        public IActionResult Delete(int id)
        {
            var data = _dbContext.VaccineApplies.FirstOrDefault(x => x.VaccineApplyId == id);
            if (data == null)
            {
                return NotFound();
            }


            _dbContext.VaccineApplies.Remove(data);
            _dbContext.SaveChanges();

            return RedirectToAction("ApplyList");
        }
    }
}
