using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaNET
{
    class OrderRange
    {
        public void build(ref string cadena)
        {


            var arreglo = cadena.Split(',').Select(Int32.Parse).ToList();
            arreglo.Sort();
            List<Int32> pares = new List<Int32>();
            List<Int32> impares = new List<Int32>();
            foreach (Int32 item in arreglo)
            {
                if (item % 2 == 0)
                {
                    pares.Add(item);
                }
                else
                {
                    impares.Add(item);
                }
            }
            if (pares != null & impares != null)
            {

                if (pares[0] >= impares[0])
                {

                    Console.WriteLine(string.Join(",", impares));
                    Console.WriteLine(string.Join(",", pares));
                }
                else
                {

                    Console.WriteLine(string.Join(",", pares));
                    Console.WriteLine(string.Join(",", impares));
                }
            }
            if (pares == null & impares != null)
            {
                Console.WriteLine(string.Join(",", impares));
            }
            if (impares == null & pares != null)
            {
                Console.WriteLine(string.Join(",", pares));
            }


        }
    }
}
