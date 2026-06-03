using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tpAhorcado.Models;

namespace tpAhorcado.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        PalabrasAhorcado palabras = new PalabrasAhorcado();
        string palabraGuiones = null;
        string palabra = palabras.ObtenerPalabra();
        ViewBag.palabra = palabra;
        for (int i = 0; i < palabra.Length; i++ ){
            palabraGuiones += "-";
        }
        ViewBag.palabraGuiones = palabraGuiones;
        return View();
    }

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
