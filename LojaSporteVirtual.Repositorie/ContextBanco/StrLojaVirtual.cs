using LojaSporteVirtual.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text;
using System.Threading.Tasks;
using LojaSporteVirtual.Repositorie.Conventions;
using LojaSporteVirtual.Repositorie.Configutations;

namespace LojaSporteVirtual.Repositorie
{
    public class StrLojaVirtual : DbContext
    {
        public StrLojaVirtual() : base("LojaVirtual")
        {

        }

        public DbSet<Produto> Produtos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            
            modelBuilder.Conventions.Add( new ModelConventions());
            //modelBuilder.Configurations.Add(new ProdutoConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());
        }
    }
}
