using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class1
    {
        double b;

        public Class1() { }
        public Class1(double b) 
        {
          this.b = b;
        }
        public void opc() 
        {
            Console.WriteLine("Ingrese una opcion");
            Console.WriteLine("1.op Vehiculo");
            Console.WriteLine("2.op Equipo de computo");
            Console.WriteLine("3.op Edificio");
            Console.WriteLine("4.op Salir");
        }

        public void setb(double b) 
        {
            this.b = b;
        }

        public double b1(double b) 
        {
            return b / 5;
        }

        public double b2(double b)
        {
            return b / 2;
        }

        public double b3(double b)
        {
            return b / 20;
        }
        public int validar(String Mensaje)
        {
            int num = 0, v;
            do
            {
                v = 1;
                try
                {
                    Console.Write(Mensaje);
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    v = 0;
                    Console.WriteLine("////////////////////////////////////");
                    Console.WriteLine("No se aceptan letras", error.Message);
                    Console.WriteLine("////////////////////////////////////");
                    opc();
                }
            } while (v == 0);
            return num;
        }
    }
}
