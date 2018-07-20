using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaSporteVirtual.Domain.Entity
{
   public class ItemCarrinho
    {
        public Produto produto { get; set; }

        public int Quantidade { get; set; }
    }
}
