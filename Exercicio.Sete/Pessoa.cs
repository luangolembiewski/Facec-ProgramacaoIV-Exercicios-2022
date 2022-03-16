using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio.Sete
{
	class Pessoa
	{
		public string Nome { get; private set; }
		public Pessoa (string nome){
			Nome = nome ??
				throw new ArgumentException(nameof(nome));
		}
			
	}
}
