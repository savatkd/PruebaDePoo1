using System;
using System.Collections.Generic;
using System.Text;

namespace ex_tercero
{
    public class Auto:Vehículo,ICalcular
    {
        public int precio { get; set; }

        public void calcular()
        {
            
            string marca = "Sedan";
            if (marca.Equals("Sedan"))
            {
                int total;
                total = 200;
                Console.WriteLine(total);
            }
            else
            {
                double total;
                double descuento;
                descuento = 200 * 1.0;
                total = 200 * descuento;
                Console.WriteLine(total);

            }
        }
    }
    
}
