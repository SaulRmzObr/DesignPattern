using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DependencyInjection
{
    public class Cerveza
    {
        private string _sNombre, _sMarca;

        public string Nombre
        {
            get { return _sNombre; }
        }
        public string Marca
        {
            get { return _sMarca; }
        }
        public Cerveza(string sNombre, string sMarca)
        {
            _sNombre = sNombre;
            _sMarca = sMarca;   
        }

    }
}
