using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1
{
    class EX2
    {
        static void Main(string[] args)
        {
            double nEleitor, votoBranco, votoNulo, votoValido;

            Console.WriteLine("Informe todos os Eleitores da cidade: ");
            nEleitor = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o total de voto em branco: ");
            votoBranco = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o total de voto nulo: ");
            votoNulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o total de voto validos: ");
            votoValido = double.Parse(Console.ReadLine());


            Console.Write("A porcentagem da população que voto em branco foi: "  + ((votoBranco * 100) / nEleitor) + "%" );
            Console.Write("\nA porcentagem da população que voto em branco foi: " + ((votoNulo * 100) / nEleitor) + "%");
            Console.Write("\nA porcentagem da população que voto em branco foi: " + ((votoValido * 100) / nEleitor) + "%");


            Console.ReadKey();
        }


    }
}
