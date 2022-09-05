using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Ganancias
{
    public class FactoryGananciaExtranjero : Ganancia
    {
        double _dPorcentaje, _dExtra;
        public FactoryGananciaExtranjero(double dPorcentaje, double dExtra)
        {
            _dPorcentaje = dPorcentaje;
            _dExtra = dExtra;
        }
        public override IGanancia GetGanancia()
        {
            return new GananciaExtranjero(_dPorcentaje, _dExtra);
        }
    }
}
