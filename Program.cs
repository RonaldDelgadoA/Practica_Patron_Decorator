using System;

namespace Practica {
public class Program{
        public static void Main(string []arg){
            var OrdenRegular1 = new OrdenRegular();
            Console.WriteLine(OrdenRegular1.CalculoTotalPrecio());
            Console.WriteLine();

            var POrden = new PreOrden();
            Console.WriteLine(POrden.CalculoTotalPrecio());
            Console.WriteLine();

            var OrPremiun = new OrdenPremiun(POrden);
            Console.WriteLine(OrPremiun.CalculoTotalPrecio());
            Console.WriteLine();
        }
    }
}

