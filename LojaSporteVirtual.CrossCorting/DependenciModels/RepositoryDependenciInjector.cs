using Autofac;
using LojaSporteVirtual.Domain.Entity;
using LojaSporteVirtual.Domain.Interface.Repository;
using LojaSporteVirtual.Repositorie;
using LojaSporteVirtual.Repositorie.Repository;

namespace LojaSporteVirtual.CrossCorting.DependenciModels
{
    public class RepositoryDependenciInjector:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType(typeof(StrLojaVirtual)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(RepositoryBase<Produto>)).As(typeof(IRepositoryBase<Produto>)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(RepositoryBase<Categoria>)).As(typeof(IRepositoryBase<Categoria>)).InstancePerLifetimeScope();
            builder.RegisterType<ProdutoRepository>().As<IProdutoRepository>().InstancePerRequest();
            builder.RegisterType<CategoriaRepository>().As<ICategoriaRepository>().InstancePerRequest();
        }
    }
}
