using Microsoft.AspNetCore.Mvc;
using Tools.Ganancias;

namespace DesignPatternsAsp.Controllers
{
    public class DetalleProductoController : Controller
    {
        public IActionResult Index(double dTotal)
        {
            //Fabricas
            FactoryGananciaLocal factoryGananciaLocal = new FactoryGananciaLocal(0.10);
            FactoryGananciaExtranjero factoryGananciaExtranjero = new FactoryGananciaExtranjero(0.10, 20);

            //Productos
            var gananciaLocal = factoryGananciaLocal.GetGanancia();
            var gananciaExtranjero = factoryGananciaExtranjero.GetGanancia();

            ViewBag.dTotalGananciaLocal = dTotal + gananciaLocal.Ganancia(dTotal);
            ViewBag.dTotalGananciaExtranjero = dTotal + gananciaExtranjero.Ganancia(dTotal);

            return View();
        }
    }
}
