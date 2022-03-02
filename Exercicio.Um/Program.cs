using System;

namespace Exercicio.Um
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor em R$: ");
            string real = Console.ReadLine();
            decimal realDec = 0.0m;
            decimal precoReal = 0.1932m;

            decimal.TryParse (real, out realDec);
            decimal resultadoConvertido = realDec * precoReal;
            Console.WriteLine($"Valor em $: {resultadoConvertido}");
            Console.ReadLine();
        }
    }
}
