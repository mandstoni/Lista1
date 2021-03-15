using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    class EX1
    {
        static void Main(string[] args)
        {
            int idade, meses, dias;

            Console.WriteLine("Informe a sua idade em anos: ");
            idade = int.Parse(Console.ReadLine());

            dias = (idade * 365);

            Console.Write("Com sua idade você ja viveu  " + dias + "dias" );

            Console.ReadKey();
        }
    }
}
