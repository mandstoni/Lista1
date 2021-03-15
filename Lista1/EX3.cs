using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    class EX3
    {
        static void Main(string[] args)
        {
            double vCustoFab,impostoDistribuidor, vCusto, vConsumidor,
             porcDistribuidor = 29, porcImpostoFab = 47;

            Console.WriteLine("Informe o valor de fabrica: ");
            vCustoFab = double.Parse(Console.ReadLine());

            impostoDistribuidor = vCustoFab + (vCustoFab * porcDistribuidor / 100);
            vCusto = vCustoFab + (vCustoFab * porcImpostoFab / 100);
            vConsumidor = vCustoFab + vCusto + impostoDistribuidor; 

            Console.Write("O valor do consumidor é: " + vConsumidor);

            Console.ReadKey();
        }
    }
}
