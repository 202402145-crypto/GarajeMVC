using Microsoft.AspNetCore.Mvc;
using GarageMVC.Models;

namespace GarageMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly Garage miGaraje;

        public HomeController()
        {
            
            miGaraje = new Garage(
                numeroGaraje: 1,
                descripcion: "Garaje de Roberto Diaz Alvarado",
                capacidadEspacios: 10
            );

          
            var auto1 = new Auto(1, "apache ", "HAA-2004");
            var auto2 = new Auto(2, "22R", "HBB-88678");
            var auto3 = new Auto(3, "Wosvaguen", "HCC-305");

            miGaraje.ingresarAuto(auto1);
            miGaraje.ingresarAuto(auto2);
            miGaraje.ingresarAuto(auto3);
        }

        public IActionResult Index()
        {
           
            return View(miGaraje);
        }
    }
}