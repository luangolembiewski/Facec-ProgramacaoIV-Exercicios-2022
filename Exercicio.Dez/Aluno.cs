namespace Exercicio.Dez
{
    class Aluno
    {
        public string Nome { get; set; }
        public int Ra { get; set; }
        public decimal Nota { get; set; }
        public int Frequencia { get; set; }

        public decimal Media(decimal nota)
        {
            decimal media = nota / 100;
        return media;
        }
        public bool Aprovacao(int frequencia)
        {
            if (frequencia/25 < 0.40)
            {
                return false;
            }
            return true;
        }

    }
    
}