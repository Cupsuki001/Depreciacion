// See https://aka.ms/new-console-template for more information

using ConsoleApp3;

public class Program
{
    public static void Main(string[] args) 
    {
        Class1 n = new Class1();
        int p;
        double v , ttv , sal ;


        do 
        {
           
            do
            {
                Console.WriteLine("//////////////////////");
                n.opc();
                p = n.validar("Seleccione una opcion: ");
                Console.WriteLine("//////////////////////");

            } while (p < 0 || p > 5);


            switch (p) 
            {
               case 1:
               {

                    do
                    {
                      v = n.validar("Ingrese el valor del Vehiculo: ");

                    } while (v <= 10000 || v > 20000);
                      ttv = n.b1(v);
                      Console.WriteLine("La depreciacion es de: " + ttv);
                        break;
                        Console.WriteLine("-----------------------------------");
               }
                case 2:
                {

                     do
                     {
                        v = n.validar("Ingrese el valor del Equipo de computo: ");
                     } while (v <= 20000 || v > 50000);
                       ttv = n.b2(v);
                       Console.WriteLine("La depreciacion es de: " + ttv);
                        break;
                        Console.WriteLine("-----------------------------------");

                    }
                case 3: 
                {
                    do
                    {
                      v = n.validar("Ingrese el valor del Edificio: ");
                    } while (v < 200000 || v < 90000);
                      ttv = n.b3(v);
                      Console.WriteLine("La depreciacion es de: " + ttv);
                        break;
                        Console.WriteLine("-----------------------------------");

                }
                default: 
                {
                        Console.WriteLine("Buen dia");
                        break;
                }
                    

            }

        } while (p == 4);
    }
}
