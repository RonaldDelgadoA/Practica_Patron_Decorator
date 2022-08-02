using System;

namespace Practica {
public class Decorador : OrdenBase
{
    protected OrdenBase orden;
    public Decorador (OrdenBase orden)
    {
        this.orden = orden;
    }
    public override double CalculoTotalPrecio()
    {
        Console.WriteLine("Calculo del Precio Total desde la Clase Decorador: ");
        return orden.CalculoTotalPrecio();
    }
}
}