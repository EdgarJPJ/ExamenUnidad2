using Microsoft.AspNetCore.Mvc;

namespace ExamenSegundaUnidad.Controllers{
   
 public class InicioController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
}