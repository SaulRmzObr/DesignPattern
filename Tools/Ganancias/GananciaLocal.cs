using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Ganancias
{
    public class GananciaLocal : IGanancia
    {
        private double _dPorcentajeGanancia;
        public GananciaLocal(double dPorcentajeGanancia)
        {
            _dPorcentajeGanancia = dPorcentajeGanancia;
        }
        public double Ganancia(double dMonto)
        {
            return dMonto * _dPorcentajeGanancia;
        }
    }
}
