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

    public IActionResult Level(string respuesta){
        bool verificar = Quiz.comprobar(respuesta);
        int nivelActual = Quiz.VerNivel();

        if(verificar){
            if(nivelActual==5){
                return View ("ganar");
            }
            else{
                ViewBag.Incorrecto="";
                return View ("Nivel" + (Quiz.VerNivel()));
            }
        }
        else{
            ViewBag.Incorrecto="Intenta de nuevo :)";
            return View ("Nivel" + (Quiz.VerNivel()));
        } 
    }

    public IActionResult IniciarRescatar(){
        int r = Rescatar.generarRandom();
        return View ("Rescatar");
    }

    public IActionResult Jugar(int respuesta){
        int cantIntentos=0;
        string devolver;
        devolver=Rescatar.devolverRespuesta(respuesta);
        ViewBag.correccion=devolver;
        cantIntentos++;
        if(respuesta!=Rescatar.ReturnRD()) return View ("Rescatar");
        else return View ("ganar");
    }
}
