using Microsoft.AspNetCore.Mvc;
using Tools.Ganancias;

namespace DesignPatternsAsp.Controllers
{
    public class DetalleProductoController : Controller
    {
        private FactoryGananciaLocal _factoryGananciaLocal;
        private FactoryGananciaExtranjero _factoryGananciaExtranjero;
        public DetalleProductoController(FactoryGananciaLocal factoryGananciaLocal, FactoryGananciaExtranjero factoryGananciaExtranjero)
        {
            _factoryGananciaLocal = factoryGananciaLocal;
            _factoryGananciaExtranjero = factoryGananciaExtranjero;
        }
        public IActionResult Index(double dTotal)
        {
            //Productos
            var gananciaLocal = _factoryGananciaLocal.GetGanancia();
            var gananciaExtranjero = _factoryGananciaExtranjero.GetGanancia();

            ViewBag.dTotalGananciaLocal = dTotal + gananciaLocal.Ganancia(dTotal);
            ViewBag.dTotalGananciaExtranjero = dTotal + gananciaExtranjero.Ganancia(dTotal);

            return View();
        }
    }
}
