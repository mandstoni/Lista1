using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    class EX4
    {
        static void Main(string[] args)
        {
            double vendas, salarioFixo, comissao, salario;
            int carro;

            Console.WriteLine("Informe a quantidade de carro vendidos: ");
            carro = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor por carro vendido: ");
            comissao = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de vendas: ");
            vendas = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o seu salario: ");
            salarioFixo = double.Parse(Console.ReadLine());

            salario = salarioFixo + (comissao * carro) + (vendas + 0.05);

            Console.Write("\nSalario final do vendedor: [%0.2f]\n\n" + salario);

            Console.ReadKey();
        }
    }
}
