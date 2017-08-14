using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PruebaNET
{
    class Program
    {
        static void Main(string[] args)
        {

            //ChangeString cls = new ChangeString();
            //string ejemplo1;
            //string ejemplo2;
            //do
            //{
            //    Console.WriteLine("Ingresar cadena");
            //    ejemplo1=Console.ReadLine();
            //    cls.build(ref ejemplo1);
            //    Console.WriteLine("salida :"+ejemplo1);
            //} while (ejemplo1 != null);

            //OrderRange cls2 = new OrderRange();
            //string ejemplo2;
            //do
            //{
            //    Console.WriteLine("Ingresar cadena ,separando como ',' ");
            //    ejemplo2 = Console.ReadLine();
            //    Console.WriteLine("salida :");
            //    cls2.build(ref ejemplo2);

            //} while (ejemplo2 != null);

   



            MoneyParts cls3 = new MoneyParts();
            string ejemplo2;
            do
            {
                Console.WriteLine("Ingresar monto ");
                ejemplo2 = Console.ReadLine();
                Console.WriteLine("salida :");
                List<List<decimal>> lista=cls3.build(ejemplo2);
                foreach (var sub_lista in lista)
                {
                    Console.WriteLine(string.Join(",", sub_lista));
                }

            } while (ejemplo2 != null);

        }
    }
}
