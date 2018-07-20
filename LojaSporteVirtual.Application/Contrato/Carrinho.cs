using LojaSporteVirtual.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaSporteVirtual.Application.Contrato
{
    public class Carrinho
    {
        private readonly List<ItemCarrinho> _itemCarrinho = new List<ItemCarrinho>();
        public void AdicionarItem(Produto produto, int quantidade)
        {
            ItemCarrinho item = _itemCarrinho.FirstOrDefault(p => p.produto.ProdutoId == produto.ProdutoId);

            if (item == null)
            {
                _itemCarrinho.Add(new ItemCarrinho
                {
                    produto = produto,
                    Quantidade = quantidade
                });
            }
            else
                item.Quantidade += quantidade;
        }

        public void RemoverItem(Produto produto)
        {
            _itemCarrinho.RemoveAll(R => R.produto.ProdutoId == produto.ProdutoId);
        }

        public decimal ObterValorTotal()
        {
            return _itemCarrinho.Sum(s => s.produto.Preco * s.Quantidade);
        }

        public void LimparCarrinho()
        {
            _itemCarrinho.Clear();
        }

        public IEnumerable<ItemCarrinho> ItensDoCarrinho
        {
            get { return _itemCarrinho.ToList(); }
        }
    }
}
