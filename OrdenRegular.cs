using System;

namespace Practica {
    public class OrdenRegular : OrdenBase
    {
        public override double CalculoTotalPrecio()
        {
            Console.Write("Calculo del Precio Total en Orden Regular: ");
            return productos.Sum(x => x.Precio);
        }
    }
}