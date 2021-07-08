using System;
using System.Collections.Generic;
namespace ex_tercero
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto vehiculo1 = new Auto();
            vehiculo1.Marca = "Sedan";
            vehiculo1.Modelo = "Toyota";
            vehiculo1.año = 2000;
            vehiculo1.precio = 200;
            Furgoneta vehículo2 = new Furgoneta();
            vehículo2.Marca = "Sedan";
            vehículo2.Modelo = "ford";
            vehículo2.año = 2000;
            vehículo2.Numero = 2;
            vehículo2.PrecioBae = 250;
            vehículo2.PrecioAsientos = 60;
            Camioneta vehículo3 = new Camioneta();
            vehículo3.Marca = "Sedan";
            vehículo3.Modelo = "SZ";
            vehículo3.año = 2000;
            vehículo3.TipoCabina = "doble";
            
            List<Auto> ListaNueva = new List<Auto>();
            ListaNueva.Add(vehiculo1);
            List<Furgoneta> ListaNueva1 = new List<Furgoneta>();
            ListaNueva1.Add(vehículo2);
            List<Camioneta> ListaNueva2 = new List<Camioneta>();
            ListaNueva2.Add(vehículo3);
            foreach (var efe in ListaNueva)
            {
                
                Console.WriteLine("Marca: " + efe.Marca);
                Console.WriteLine("Modelo: " + efe.Modelo);
                Console.WriteLine("año: " + efe.año);
                Console.WriteLine("----");
                efe.calcular();
                Console.WriteLine("----");
            }
            foreach (var efe2 in ListaNueva1)
            {

                Console.WriteLine("Marca: " + efe2.Marca);
                Console.WriteLine("Modelo: " + efe2.Modelo);
                Console.WriteLine("año: " + efe2.año);
                Console.WriteLine("----");
                efe2.calcular();
                Console.WriteLine("----");
            }
            foreach (var efe3 in ListaNueva2)
            {

                Console.WriteLine("Marca: " + efe3.Marca);
                Console.WriteLine("Modelo: " + efe3.Modelo);
                Console.WriteLine("año: " + efe3.año);
                Console.WriteLine("----");
                efe3.calcular();
            }
        }
    }
}
