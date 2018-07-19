
using Autofac;
using LojaSporteVirtual.Domain.Entity;
using LojaSporteVirtual.Domain.Interface.Service;
using LojaSporteVirtual.Domain.Service;

namespace LojaSporteVirtual.CrossCorting.DependenciModels
{
    public class ServiceDependenciInjector:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType(typeof(ServiceBase<Categoria>)).As(typeof(ServiceBase<Categoria>)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(ServiceBase<Produto>)).As(typeof(ServiceBase<Produto>)).InstancePerLifetimeScope();

            builder.RegisterType<ProdutoService>().As<IProdudoService>().InstancePerRequest();
            builder.RegisterType<CategoriaService>().As<ICategoriaService>().InstancePerRequest();
        }
    }
}
