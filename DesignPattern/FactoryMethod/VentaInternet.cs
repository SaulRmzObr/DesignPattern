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
    public class VentaInternet : IVenta
    {
        private double _dDescuento;

        public VentaInternet(double dDescuento) 
        {
            _dDescuento = dDescuento;
        }
        public void Vender(double dTotal)
        {
            Console.WriteLine($"La venta por internet tiene un total" +
            $" de {dTotal - _dDescuento} con un descuento aplicado de {_dDescuento}");
        }
    }
}
