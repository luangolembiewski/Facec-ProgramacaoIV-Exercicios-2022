using System;

namespace Exercicio.Dez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno()
            {
                Nome = "Luan",
                Ra = 424,
                Nota = 60,
                Frequencia = 12
            };
            Console.WriteLine($"Nome: {aluno1.Nome} RA: {aluno1.Ra} Nota: {aluno1.Nota} Frequencia: {aluno1.Frequencia} Media: {aluno1.Media(aluno1.Nota)} => {aluno1.Aprovacao(aluno1.Frequencia)}");
        }
    }
}
