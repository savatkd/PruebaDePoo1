using System;
using System.Collections.Generic;
using System.Text;

namespace ex_tercero
{
    public class Camioneta:Vehículo,ICalcular
    {
        public string TipoCabina { get; set; }

        public void calcular()
        {
            if (TipoCabina.Equals("doble"))
            {
                int total = 20000;
                Console.WriteLine(total);
            }
            if (TipoCabina.Equals("simple"))
            {
                int total = 15000;
                Console.WriteLine(total);
            }
        }
    }
}
