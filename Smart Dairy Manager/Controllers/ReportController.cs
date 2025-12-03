// Controllers/ReportController.cs
using Microsoft.AspNetCore.Mvc;
using Smart_Dairy_Manager.Data;
using Smart_Dairy_Manager.ViewModel;
public class ReportController : Controller
{
    private readonly ApplicationDbContext _context;

    public ReportController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Return the view
    public IActionResult MonthlyReport(DateTime? date)
    {
        // Use current date if not provided
        date ??= DateTime.Now;

        var ReportVM = new ReportItemVM();

        // Example query for the month of the provided date
        ReportVM.FoodAmmount = _context.FeedManagements
                                .Where(f => f.FeedingTime.Month == date.Value.Month && f.FeedingTime.Year == date.Value.Year)
                                .Sum(f => f.Quantity);

        ReportVM.MilkCollection = _context.MilkCollections
                                    .Where(m => m.Date.Month == date.Value.Month && m.Date.Year == date.Value.Year)
                                    .Sum(m => m.TotalYield);

        ReportVM.VaccineCost = _context.VaccineApplies
                                    .Where(n => n.Applydate.Month==date.Value.Month)
                                   .Sum(n => n.ApplyAmmount);


        return View(ReportVM);
    }


}
