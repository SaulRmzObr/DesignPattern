using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Ganancias
{
    public class GananciaExtranjero : IGanancia
    {
        private double _dPorcentaje, _dExtra;

        public GananciaExtranjero(double dPorcentaje, double dExtra)
        {
            _dPorcentaje = dPorcentaje;
            _dExtra = dExtra;
        }

        public double Ganancia(double dMonto)
        {
            return (dMonto * _dPorcentaje) + _dExtra;
        }
    }
}
