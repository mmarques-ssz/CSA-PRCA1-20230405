using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            int soma;
            Console.Write("Digite o 1º número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Digite o 2º número: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            soma = n1 + n2;
            Console.Write("Resultado da soma: ");
            Console.WriteLine(soma);
            Console.WriteLine();
        }
    }
}
