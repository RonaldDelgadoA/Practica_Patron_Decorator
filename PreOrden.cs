using System;

namespace Practica {
    public class PreOrden : OrdenBase
    {
        public override double CalculoTotalPrecio()
        {
            Console.Write("Calculo del Precio Total en PreOrden: ");
            return productos.Sum(x => x.Precio) * 0.9;
        }
    }
}