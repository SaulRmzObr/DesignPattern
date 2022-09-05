using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public class Singleton
    {
        private readonly static Singleton _instancia = new Singleton(); //readonly = solo lectura

        public static Singleton Instancia
        {
            get
            {
                return _instancia;
            }
        }
        private Singleton() { }
    }
}
