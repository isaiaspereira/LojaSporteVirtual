﻿using LojaEsporeVirtual.Web.Helps;
using LojaSporteVirtual.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaEsporeVirtual.Web.Models
{
    public class ProdutosViewModel
    {
        public IEnumerable<Produto> Produtos { get; set; }

        public Paginacao Paginacao { get; set; }

        public string CategoriaAtual { get; set; }
    }
}