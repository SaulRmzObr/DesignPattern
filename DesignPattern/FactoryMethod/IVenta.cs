using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    /// <summary>
    /// Clase Interfaz Product
    /// </summary>
    public interface IVenta
    {
        public void Vender(double dTotal);
    }
}
