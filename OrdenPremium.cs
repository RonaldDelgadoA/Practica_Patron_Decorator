using System;

namespace Practica {
public class OrdenPremiun : Decorador
{
    public OrdenPremiun(OrdenBase orden) : base(orden){ }
    public override double CalculoTotalPrecio()
    {
        Console.WriteLine("Calculo Total de Precio Orden Premium: ");
        var precioOrdenPrecio = base.CalculoTotalPrecio();
        return precioOrdenPrecio * 0.9;
    }

}
}