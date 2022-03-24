using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo.Um
{
	class Pessoa
	{
		public string Nome { get; private set; }
		public Pessoa(string nome)
		{
			Nome = nome ??
				throw new ArgumentException(nameof(nome));
		}

	}
}