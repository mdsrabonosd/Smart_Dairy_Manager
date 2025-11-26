using Microsoft.AspNetCore.Mvc;
using Smart_Dairy_Manager.ViewModel;

namespace Smart_Dairy_Manager.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 
        public IActionResult dairyreport()
        {


            var reportVM = new ReportVM();

            //reportVM.TotalMilk = 125;

            //reportVM.TotalFood = 500;

            //reportVM.VaccineCost = 1000;

            return View(reportVM);
        }
    }
}
