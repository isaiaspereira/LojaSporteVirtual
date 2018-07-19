using LojaSporteVirtual.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace LojaSporteVirtual.Repositorie.Configutations
{
    class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(k => k.ProdutoId);

            Property(p => p.Descricao)
                .IsOptional()
                .HasColumnType("varchar")
                .HasMaxLength(500);

            Property(p => p.Nome)
                .IsOptional()
                .HasColumnType("varchar")
                .HasMaxLength(200);

            Property(p => p.Preco)
                .HasPrecision(16, 2);


            HasRequired(c => c.Categoria)
                .WithMany(c => c.Produtos)
                .HasForeignKey(c => c.CategoriaId);

        }
    }
}
