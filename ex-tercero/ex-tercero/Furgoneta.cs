using System;
using System.Collections.Generic;
using System.Text;

namespace ex_tercero
{
    public class Furgoneta : Vehículo, ICalcular
    {
        public int Numero { get; set; }
        public int PrecioBae { get; set; }
        public int PrecioAsientos { get; set; }

        public void calcular()
        {
            double total = PrecioBae + PrecioAsientos * Numero;
            Console.WriteLine(total);
        }
    }


}
