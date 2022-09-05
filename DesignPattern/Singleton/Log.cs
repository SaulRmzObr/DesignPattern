using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public class Log
    {
        private readonly static Log _instancia = new Log();
        private string ruta = "log.txt";
        public static Log Instancia
        {
            get { return _instancia; }
        }
        private Log() { }
        public void Guardar(string sMensaje)
        {
            File.AppendAllText(ruta, string.Format("{0}{1}", sMensaje, Environment.NewLine));
        }
    }
}
