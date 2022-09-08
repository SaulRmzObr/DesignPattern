using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DependencyInjection
{
    public class TomarConCerveza
    {
        private Cerveza _cerveza;
        private double _dCantidadAgua;
        private double _dCantidadAzucar;

        public TomarConCerveza(Cerveza cerveza, double dCantidadAgua, double dCantidadAzucar)
        {
            _cerveza = cerveza;
            _dCantidadAgua = dCantidadAgua;
            _dCantidadAzucar = dCantidadAzucar;
        }

        public void Preparar()
        {
            Console.WriteLine($"Preparamos bebida que tiene agua {_dCantidadAgua} " +
                $"azucar {_dCantidadAzucar} y cerveza {_cerveza.Nombre} {_cerveza.Marca}");
        }
    }
}
