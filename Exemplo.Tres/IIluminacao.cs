﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo.Tres
{
    public interface IIluminacao : IEletroDomestico
    {
        void ObterPotenciaLampada();
    }
}