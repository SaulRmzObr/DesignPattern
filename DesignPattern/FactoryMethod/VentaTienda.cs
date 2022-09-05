using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    /// <summary>
    /// Clase Concrete Product
    /// </summary>
    public class VentaTienda : IVenta
    {
        private double _dExtra;

        public VentaTienda(double dExtra)
        {
            _dExtra = dExtra;
        }

        public void Vender(double dTotal)
        {
            Console.WriteLine($"La venta de tienda tiene un total de {dTotal + _dExtra}");
        }
    }
}
