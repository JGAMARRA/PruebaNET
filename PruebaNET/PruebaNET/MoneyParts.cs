using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaNET
{
    class MoneyParts
    {

        public List<List<decimal>> build(string p_monto)
        {
            List<decimal> coins = new List<decimal>();
            coins.Add(0.05m);
            coins.Add(0.1m);
            coins.Add(0.2m);
            coins.Add(0.5m);
            coins.Add(1);
            coins.Add(2);
            coins.Add(5);
            coins.Add(10);
            coins.Add(20);
            coins.Add(50);
            coins.Add(100);
            coins.Add(200);

            decimal monto = Convert.ToDecimal(p_monto);            
            decimal coin;
            int num_monedas;
            decimal num_resto;
            List<List<decimal>> respuesta=new List<List<decimal>>();
            List<decimal> resp ;
            int i = 0;
            do
            {
                resp = new List<decimal>();
                coin = coins[i];
                num_monedas = (int) (monto / coin);
                num_resto = (monto % coin);
                gen_arr(resp,coin, num_monedas);

                if (num_resto != 0)
                {
                    gen_arr(resp, monto-num_monedas*coin, num_resto);
                }

                respuesta.Add(resp);
                i = i + 1;
            } while (monto > coins[i+1]);

            
            return respuesta;
        }
        public void gen_arr(List<decimal> resp, decimal p_monto, decimal val) {
           // List<decimal> resp = new List<decimal>();
            for (int i = 0; i < val; i++)
            {
                resp.Add(p_monto);
            }
         
        }
    }
}
