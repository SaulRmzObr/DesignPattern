// See https://aka.ms/new-console-template for more information
using DesignPattern.DependencyInjection;
using DesignPattern.FactoryMethod;
using DesignPattern.Singleton;

Console.WriteLine("Hello, World!");

#region Singleton
var singleton = Singleton.Instancia;

Log.Instancia.Guardar("prueba");
Log.Instancia.Guardar("otra prueba");

#endregion

#region Factory Method
double dComisionExtra = 20;
double dDescuento = 100;
double totalVentaEnInternet = 1600;
double totalVentaEnTienda = 950;

Venta factoryVentaTienda = new FactoryVentaTienda(dComisionExtra);
Venta factoryVentaInternet = new FactoryVentaInternet(dDescuento);

IVenta ventaEnTienda = factoryVentaTienda.GetVenta();
IVenta ventaEnInternet = factoryVentaInternet.GetVenta();

ventaEnTienda.Vender(totalVentaEnTienda);
ventaEnInternet.Vender(totalVentaEnInternet);

#endregion

#region Dependency Injection
Cerveza cerveza = new Cerveza("Negra Modelo", "Corona");
TomarConCerveza tomarConCerveza = new TomarConCerveza(cerveza,20,15);
tomarConCerveza.Preparar();
#endregion
