using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaSporteVirtual.Domain.Entity
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }


    }
}
