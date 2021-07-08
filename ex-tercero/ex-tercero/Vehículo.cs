using System;
using System.Collections.Generic;
using System.Text;

namespace ex_tercero
{
    public class Vehículo
    {
        public  String Marca { get; set; }
        public  String Modelo { get; set; }
        public int año { get; set; }
        public void Mostrar()
        {
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine(año);

        }
    }
}
