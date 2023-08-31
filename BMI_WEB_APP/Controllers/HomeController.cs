using Microsoft.AspNetCore.Mvc;
public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(BmiCalculator model)
    {
        if (ModelState.IsValid)
        {
            return View(model);
        }

        return View();
    }
}