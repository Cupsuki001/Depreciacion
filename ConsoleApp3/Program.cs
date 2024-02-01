// See https://aka.ms/new-console-template for more information

using ConsoleApp3;

public class Program
{
    public static void Main(string[] args) 
    {
        Class1 n = new Class1();
        int p;
        double v , ttv , e , tte , d , ttd , sal;
        do 
        {

            Console.WriteLine("Ingrese una opcion");
            Console.WriteLine("1.op Vehiculo");
            Console.WriteLine("2.op Equipo de computo");
            Console.WriteLine("3.op Edificio");
            Console.WriteLine("4.op Salir");
            p = int.Parse(Console.ReadLine());

            switch (p) 
            {
               case 1:
                    {

                        do
                        {
                            v = n.validar("Ingrese el valor del Vehiculo: ");

                        } while (v <= 10000 || v > 20000);
                        ttv = v / 5;
                        Console.WriteLine("La depreciacion es de: " + ttv);
                    }
                    break;


                case 2:
                    {

                        do
                        {
                            e = n.validar("Ingrese el valor del Equipo de computo: ");
                        } while (e <= 20000 || e > 50000);
                        tte = e / 2;
                        Console.WriteLine("La depreciacion es de: " + tte);
                        break;
                    }

                case 3: 
                    {
                        do
                        {
                            d = n.validar("Ingrese el valor del Edificio: ");
                        } while (d < 200000 || d > 90000);
                        ttd = d / 20;
                        Console.WriteLine("La depreciacion es de: " + ttd);
                        break;

                    }


            }
            Console.WriteLine("mamyuca");


        } while (p == 4);
    }
}
