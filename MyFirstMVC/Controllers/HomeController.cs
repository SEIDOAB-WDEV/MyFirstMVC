using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyFirstMVC.Models;
using Services;

namespace MyFirstMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    ICoolLists _service = null;

    public HomeController(ILogger<HomeController> logger, ICoolLists service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult MyPage()
    {
        ViewData["Title"] = "Martins page";

        var vm = new vwmMyPage();
        vm.Latin = _service.LatinSentences.Take(5).ToList();


        return View("MyPage", vm);
    }

    [HttpGet]
    public IActionResult Privacy()
    {
        return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

