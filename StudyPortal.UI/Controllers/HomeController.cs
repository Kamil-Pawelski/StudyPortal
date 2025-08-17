using System.Diagnostics;
using Domain.Commons;
using Domain.Entities.CardsSet;
using Microsoft.AspNetCore.Mvc;

namespace StudyPortal.Controllers;

public class HomeController(ILogger<HomeController> logger) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public List<CardSet> GetCardsSet()
    {
        var query = new CardSetQuery();

        return 
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new Error ( "Error", ErrorType.BadRequest ));
    }
}
