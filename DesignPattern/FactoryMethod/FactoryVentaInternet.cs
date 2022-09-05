using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    /// <summary>
    /// Clase Concrete Creator
    /// </summary>
    public class FactoryVentaInternet : Venta
    {
        private double _dDescuento;
        public FactoryVentaInternet(double dDescuento)
        {
            _dDescuento = dDescuento;
        }

        public override IVenta GetVenta()
        {
            return new VentaInternet(_dDescuento);
        }
    }
}
