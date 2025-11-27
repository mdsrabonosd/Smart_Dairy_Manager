// Controllers/ReportController.cs
using Microsoft.AspNetCore.Mvc;
using Smart_Dairy_Manager.Data;   
public class ReportController : Controller
{
    private readonly ApplicationDbContext _context;

    public ReportController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Return the view
    public IActionResult Index()
    {
        return View();
    }
    
}
