using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebPersonal.Models;

namespace WebPersonal.Controllers;

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

    public IActionResult IronMaiden()
    {
        return View();
    }

    public IActionResult Nirvana()
    {
        return View();
    }
    public IActionResult PierceTheVeil()
    {
        return View();
    }

    public IActionResult Bathory()
    {
        return View();
    }

    public IActionResult Empezar(){
        Quiz.iniciar();
        return View("Nivel1");
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Level(int nivel, string respuesta){
        bool verificar = Quiz.comprobar(respuesta, nivel);
        
        if(verificar == true && nivel<5){
            ViewBag.Incorrecto="";
            return View ("Nivel" + (Quiz.VerNivel()));
        }
        else if (verificar == true && nivel== 5){
            ViewBag.Incorrecto="";
            return View ("ganar");
        }
        else{
            ViewBag.Incorrecto="Intenta de nuevo :)";
            return View ("Nivel" + (Quiz.VerNivel()));
        } 
    }
}
