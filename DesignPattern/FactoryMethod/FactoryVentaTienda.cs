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
    public class FactoryVentaTienda : Venta
    {
        private double _dExtra;
        public FactoryVentaTienda(double dExtra)
        {
            _dExtra = dExtra;
        }

        public override IVenta GetVenta()
        {
            return new VentaTienda(_dExtra);
        }
    }
}
