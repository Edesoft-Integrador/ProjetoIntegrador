﻿using seq.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using seq.Domain.Entities.LUFT;

namespace seq.Processo
{
    public interface IAmazonLUFTProcesso
    {
        Task Processa(transmission trans, string nomeArquivo);
    }
}
