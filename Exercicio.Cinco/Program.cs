﻿using System;

namespace Exercicio.Cinco
{
    class Program
    {
        static void Main(string[] args)
        {
            string repetir = "s";
            while (repetir.Equals("s"))
            {
                Console.WriteLine("Informe o primeiro valor!");
                String valorUmStr = Console.ReadLine();
                Console.WriteLine("Informe o segundo valor!");
                String valorDoisStr = Console.ReadLine();
                Console.WriteLine("======Informe a operação======");
                Console.WriteLine("1 => adição");
                Console.WriteLine("2 => subtração");
                Console.WriteLine("3 => multiplicação");
                Console.WriteLine("4 => divisão");
                Console.WriteLine("5 => sobra da divisão");
                string operacao = Console.ReadLine();

                decimal valorUm = 0.0m;
                decimal valorDois = 0.0m;
                decimal.TryParse(valorUmStr, out valorUm);
                decimal.TryParse(valorDoisStr, out valorDois);

                if (operacao.Equals("1"))
                {
                    Console.WriteLine($"Resultado: {valorUm}+{valorDois}={(valorUm + valorDois)}");
                }
                else if (operacao.Equals("2"))
                {
                    Console.WriteLine($"Resultado: {valorUm}-{valorDois}={(valorUm - valorDois)}");
                }
                else if (operacao.Equals("3"))
                {
                    Console.WriteLine($"Resultado: {valorUm}x{valorDois}={(valorUm * valorDois)}");
                }
                else if (operacao.Equals("4"))
                {
                    Console.WriteLine($"Resultado: {valorUm}/{valorDois}={(valorUm / valorDois)}");
                }
                else if (operacao.Equals("5"))
                {
                    Console.WriteLine($"Resultado: {valorUm}/{valorDois}=> Resto={(valorUm % valorDois)}");
                }
                Console.WriteLine("Deseja Continuar? s/n");
                repetir = Console.ReadLine();
                Console.WriteLine("");
            }
            

        }
    }
}