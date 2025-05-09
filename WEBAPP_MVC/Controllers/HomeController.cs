using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WEBAPP_MVC.Domain.Entities;
using WEBAPP_MVC.Models;

namespace WEBAPP_MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [Route("Rota/Nomeada")]
    public IActionResult RotaNomeada()
    {
        return View();
    }

    [Route("Class/Details")]
    public IActionResult ClassDetails()
    {
        var clazz = new ClassEntity
        {
            Name = "Name 1",
            Class = "Class 1"
        };
        return View(clazz);
    }

    [Route("List/Classes")]
    public IActionResult ListClasses()
    {
        var classes = new List<ClassEntity>
        {
            new ClassEntity {Name = "Name 1",Class = "Class 1"},
            new ClassEntity { Name = "Name 2", Class = "Class 2" },
            new ClassEntity { Name = "Name 3", Class = "Class 3" }
        };



        return View(classes);
    }

    [HttpPost]
    public IActionResult CreateClass(ClassEntity model)
    {
        if(ModelState.IsValid)
        {
            //Salva dados no banco

            return RedirectToAction("ListClasses");
        }
        
        return View(model);
    }

    [HttpGet]
    public IActionResult CreateClass()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
