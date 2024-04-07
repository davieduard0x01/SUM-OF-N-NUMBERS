using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de números : ");
            int quant = int.Parse(Console.ReadLine());
            int resultado = 0;
            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine("Digite o {0}° : " ,i+1);
                int num = int.Parse(Console.ReadLine());
                resultado += num;

            }
            Console.WriteLine("RESULTADO TOTAL = "+resultado);
            Console.ReadLine();

        }

    }
}
