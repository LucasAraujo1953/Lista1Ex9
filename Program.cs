using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d;
            double a;

            Console.WriteLine("Para calcular a área de um círculo, precisamos de um diâmetro");
            Console.Write("Qual é o valor do diâmetro: ");
            d=double.Parse(Console.ReadLine());

            a = 0.25 * Math.PI * (d*d);
            Console.WriteLine("O valor da área de um círculo é {0}", a);
        }
    }
}
