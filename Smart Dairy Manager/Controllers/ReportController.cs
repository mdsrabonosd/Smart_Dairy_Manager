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

        ReportVM.DateTime = date;

        // Food Amount sum
        ReportVM.FoodAmmount = _context.FeedManagements
                                .Where(f => f.FeedingTime.Month == date.Value.Month
                                         && f.FeedingTime.Year == date.Value.Year)
                                .Sum(f => (double?)f.Quantity) ?? 0;

        // Milk Collection sum
        ReportVM.MilkCollection = _context.MilkCollections
                                    .Where(m => m.Date.Month == date.Value.Month
                                             && m.Date.Year == date.Value.Year)
                                    .Sum(m => (double?)m.TotalYield) ?? 0;

        // Vaccine sum
        ReportVM.VaccineAmount = _context.VaccineApplies
                                    .Where(n => n.Applydate.Month == date.Value.Month
                                             && n.Applydate.Year == date.Value.Year)
                                    .Sum(n => (double?)n.ApplyAmmount) ?? 0;

        return View(ReportVM);
    }



}
