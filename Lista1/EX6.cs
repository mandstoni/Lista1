using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    class EX6
    {
        static void Main(string[] args)
        {
            double salarioFixo = 0, valorRecebido = 0, valorVenda = 0 ;


            Console.WriteLine("Informe salario: ");
            salarioFixo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor da venda: ");
            valorVenda = double.Parse(Console.ReadLine());

            if(valorVenda <= 1500)
            {
                valorRecebido = valorVenda + (valorVenda * 0.03);
                Console.WriteLine("O valor recebido foi de:  " + valorRecebido);
            }
            else
            {
                double valorAcima = (valorVenda - 1500) * 0.05;
                valorRecebido = valorVenda + (1500 * 0.03) + valorAcima;

                Console.WriteLine("O valor recebido foi de:  " + valorRecebido );

            }
            Console.WriteLine("O valor recebido com comissão e salario foi de:  " + valorRecebido + salarioFixo);

            Console.ReadKey();
        }
    }
}
