using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Aplikacja.Models;



public class HomeController : Controller
{

    public static bool logged_in=false;

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        if (HttpContext.Session.Keys.Contains("logged_in") && HttpContext.Session.GetString("logged_in")=="True"){
            return View();
        }
        else{
            return RedirectToAction("Login");
        }
        
    }

    public IActionResult Privacy()
    {
        return View();
    }


    //Login view
    public IActionResult Login(){
        return View();
    }

    //Login form controller
    [HttpPost]
    public IActionResult LoginForm(IFormCollection form){
        HttpContext.Session.SetString("logged_in", "True");
        logged_in=true;
        return RedirectToAction("Index");
    }

    //Logout ling - update session, redirect to login page
    public IActionResult Logout(){
        HttpContext.Session.SetString("logged_in", "False");
        logged_in=false;
        return RedirectToAction("Login");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
