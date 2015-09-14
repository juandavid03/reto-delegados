
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{

    public delegate string zona(string zonas);



    class Program

    {



        public static string zonas(string zona)
        {
            if (zona == "1")
            {
                int p1;
                string precio;
                int impuesto;
                Console.WriteLine("ingrese un el precio");
                precio = Console.ReadLine();
                int.TryParse(precio, out impuesto);
                p1 = impuesto * 25 / 100;


            }
            if (zona == "2")
            {
                int p2;
                string precio;
                int impuesto;
                Console.WriteLine("ingrese un el precio");
                precio = Console.ReadLine();
                int.TryParse(precio, out impuesto);
                p2 = (impuesto * 12 / 100) + 25;


            }
            if (zona == "3")
            {
                int p3;
                string precio;
                int impuesto;
                Console.WriteLine("ingrese un el precio");
                precio = Console.ReadLine();
                int.TryParse(precio, out impuesto);
                p3 = impuesto * 8 / 100;


            }

            if (zona == "4")
            {
                int p4;
                string precio;
                int impuesto;
                Console.WriteLine("ingrese un el precio");
                precio = Console.ReadLine();
                int.TryParse(precio, out impuesto);
                p4 = (impuesto * 4 / 100) + 25;


            }

            return zona;

        }
    }
}


public static int precios1(int p1)
{
    Console.WriteLine("el impuesto a pagar es {0}", p1);
    return p1;

}
public static  int precios2(int p2)
{
    Console.WriteLine("el impuesto a pagar es {0}", p2);
    return p2;
}
public static  int precios3(int p3)
{
    Console.WriteLine("el impuesto a pagar es {0}", p3);
    return p3;

}
public static int precio4(int p4)
{
    Console.WriteLine("el impuesto a pagar es {0}", p4)
        return p4;

      }

static void Main(string[] args)
{
    string zone;
    do
    {
        Console.WriteLine("escriba salir para salir: ");
        Console.WriteLine();
        Console.WriteLine("ingrese el numero de una zona");

        zone = Console.ReadLine();
        zona zona = zonas;
        zonas(zone);

        Console.ReadKey();
    }
    while (zone != "salir");

}
}
