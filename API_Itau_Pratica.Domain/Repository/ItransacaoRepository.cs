﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_Itau_Pratica.Domain.Dtos;
using API_Itau_Pratica.Domain.Entidades;

namespace API_Itau_Pratica.Domain.Repository
{
    public interface ItransacaoRepository
    {
        public string FazendoTransacao(postTransacao transacao);
        public string DeletandoTransacao(int id);
    }
}
