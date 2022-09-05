namespace Tools
{
    public sealed class Log
    {
        private static Log _instancia = null;
        private string _ruta;
        private static Object _protect = new object();
        public static Log GetInstance(string ruta)
        {
            lock (_protect) 
            {
                if (_instancia == null)
                {
                    _instancia = new Log(ruta);
                }
            }
            
            return _instancia;
        }
        private Log(string ruta)
        {
            this._ruta = ruta;
        }
        public void Guardar(string sMensaje)
        {
            File.AppendAllText(_ruta, string.Format("{0}{1}", sMensaje, Environment.NewLine));
        }
        
    }
}