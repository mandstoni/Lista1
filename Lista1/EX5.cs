using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    class EX5
    {
        static void Main(string[] args)
        {
            string nome, sexo = "";
            double altura, peso;

            Console.WriteLine("Informe seu nome: ");
            nome = (Console.ReadLine());

            Console.WriteLine("Informe sua altura (por exemplo: 1,57): ");
            altura = double.Parse(Console.ReadLine());

            while(sexo != "M" && sexo != "F") {
                Console.WriteLine("Informe seu sexo (F ou M):  ");
                sexo = (Console.ReadLine().ToUpper());
            }
            if (sexo == "M")
            {
                peso = (72.7 * altura) - 58;
                Console.Write("Meu nome é: " + nome + "  e meu peso ideal é: " + peso);
            }
            else
            {
                peso = (62.1 * altura) - 44.7;
                Console.Write("Meu nome é: " + nome + "e meu peso ideal é: " + peso);
            }
            Console.ReadKey();

        }
    
    }
}
