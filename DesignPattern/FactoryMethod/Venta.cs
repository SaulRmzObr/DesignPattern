using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    /// <summary>
    /// Clase Creator
    /// </summary>
    public abstract class Venta
    {
        public abstract IVenta GetVenta();
    }
}
