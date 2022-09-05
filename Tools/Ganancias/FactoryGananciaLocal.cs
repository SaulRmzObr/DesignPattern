using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Ganancias
{
    public class FactoryGananciaLocal : Ganancia
    {
        private double _dPorcentaje;
        public FactoryGananciaLocal(double dPorcentaje)
        {
            _dPorcentaje = dPorcentaje; 
        }

        public override IGanancia GetGanancia()
        {
            return new GananciaLocal(_dPorcentaje);
        }
    }
}
