using System;

namespace Exercicio.Dois
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor em $: ");
            string real = Console.ReadLine();
            decimal realDec = 0.0m;
            decimal precoDolar = 5.22m;

            decimal.TryParse(real, out realDec);
            decimal resultadoConvertido = realDec * precoDolar;
            Console.WriteLine($"Valor em R$: {resultadoConvertido}");
            Console.ReadLine();
        }
    }
}
