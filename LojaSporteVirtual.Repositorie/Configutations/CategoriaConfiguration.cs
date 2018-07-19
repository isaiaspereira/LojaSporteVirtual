using LojaSporteVirtual.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaSporteVirtual.Repositorie.Configutations
{
   public class CategoriaConfiguration:EntityTypeConfiguration<Categoria>
    {
        public CategoriaConfiguration()
        {
            HasKey(k => k.CategoriaId);


        }
    }
}
