﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reto
{ 
   // public delegate string zona(string zonas);
  //  public delegate int inpuesto(int pago);
         
    public class zona1 {
    
        public void dinero(int pagos){
            pagos = pagos * 25 / 100;

            Console.WriteLine("los impuestos son "+pagos);
            
            Console.ReadKey();
        }
    }
    public class zona2
    {

        public void dinero(int pagos)
        {
            pagos = (pagos * 12 / 100) + 25;

            Console.WriteLine("los impuestos son " + pagos);
            Console.ReadKey();
        }
    }
    public class zona3
    {

        public void dinero(int pagos)
        {
            pagos = pagos * 8 / 100;

            Console.WriteLine("los impuestos son " + pagos);
            Console.ReadKey();
        }
    }
    public class zona4
    {

        public void dinero(int pagos)
        {
            pagos = (pagos * 4 / 100) + 25;

            Console.WriteLine("los impuestos son " + pagos);
            Console.ReadKey();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            string zona, precio;
            int precio1;
            Console.WriteLine("ingrese la zona");
            zona = Console.ReadLine();
            Console.WriteLine("cual es el precio");
            precio = Console.ReadLine();
            if (int.TryParse(precio, out precio1))
            {
                if (zona == "zona1")
                {
                   zona1 impuesto=new zona1();
                    impuesto.dinero(precio1);

                }
                if (zona == "zona2")
                {
                    zona2 impuesto = new zona2();
                    impuesto.dinero(precio1);
                }
                if (zona == "zona3")
                {
                    zona3 impuesto = new zona3();
                    impuesto.dinero(precio1);
                }
                if (zona == "zona4")
                {
                    zona4 impuesto = new zona4();
                    impuesto.dinero(precio1);
                }
            }

            Console.ReadKey();

        }

       /* public static  string zonas(string zona)
        {
            if (zona == "zona1")
            {
                string precio;
                int impuesto;
                Console.WriteLine("ingrese un el precio");
                precio = Console.ReadLine();
                int.TryParse(precio, out impuesto);
                inpuesto si = preciosz1;

                si(impuesto);
                
            }
            if (zona == "zona2")
            {
                string precio;
                int impuesto;
                Console.WriteLine("ingrese un el precio");
                precio = Console.ReadLine();
                int.TryParse(precio, out impuesto);
                inpuesto si = preciosz2;

                si(impuesto);
               
            }

            if (zona == "zona3")
            {
                string precio;
                int impuesto;
                Console.WriteLine("ingrese un el precio");
                precio = Console.ReadLine();
                int.TryParse(precio, out impuesto);
                inpuesto si = preciosz3;

                si(impuesto);

            }

            if (zona == "zona4")
            {
                string precio;
                int impuesto;
                Console.WriteLine("ingrese un el precio");
                precio = Console.ReadLine();
                int.TryParse(precio, out impuesto);
                inpuesto si = preciosz4;

                si(impuesto);

            }
           
          return zona;
                   
        }
        public static int preciosz1(int asd)
        {
            asd = asd * 25 / 100;


            Console.WriteLine("el impuesto a pagar es " + asd);
            return asd;
        }
        public static int preciosz2(int asd)
        {

            asd = (asd * 12 / 100) + 25;

            Console.WriteLine("el impuesto a pagar es "+asd);
            return asd;
        }
        public static int preciosz3(int asd)
        {
           asd =asd * 8 / 100;
           Console.WriteLine("el impuesto a pagar es " + asd);

            return asd;
        }
        public static int preciosz4(int asd)
        {
            asd = (asd * 4 / 100) + 25;

            Console.WriteLine("el impuesto a pagar es " + asd);

            return asd;
        }

        static void Main(string[] args)
        {
            string zone;
        do
        {
            Console.WriteLine("escriba salir para salir :v");
            Console.WriteLine();
            Console.WriteLine("ingrese una zona");

            zone = Console.ReadLine();
            zona zona = zonas;
            zonas(zone);

            Console.ReadKey();
        } 
        while (zone != "salir");

        }
        */
    /*    static void Main(string[] args)
        {
            
           string zona, precio;
            int precio1;
            Console.WriteLine("ingrese la zona");
            zona=Console.ReadLine();
            Console.WriteLine("cual es el precio");
            precio = Console.ReadLine();
            if(int.TryParse(precio, out precio1)){
            if (zona == "zona1")
            {precio1 = precio1 * 25 / 100;
                Console.WriteLine("el impuesto por el producto es \n"+precio1);
                
            }
            if (zona == "zona2")
            {
                precio1 = (precio1 * 12 / 100)+25;
                Console.WriteLine("el impuesto por el producto es \n" + precio1);

            }
            if (zona == "zona3")
            {
                precio1 = precio1 * 8 / 100;
                Console.WriteLine("el impuesto por el producto es \n" + precio1);

            }
            if (zona == "zona4")
            {
                precio1 =( precio1 * 4 / 100)+25;
                Console.WriteLine("el impuesto por el producto es \n" + precio1);

            }
          }

            Console.ReadKey();

        }*/

         
    }
}
