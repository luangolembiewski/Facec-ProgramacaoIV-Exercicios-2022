using System;

namespace Exercicio.Quatro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o ano de nascimento!");
            string nascimentoStr = Console.ReadLine();
            int idade;
            int anoNascimento;
            int anoAtual = DateTime.Today.Year;

            int.TryParse(nascimentoStr, out anoNascimento);
            idade = (anoAtual - anoNascimento);

            Console.WriteLine($"A idade é {idade}");
        }
    }
}
