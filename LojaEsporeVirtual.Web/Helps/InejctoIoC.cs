using Autofac;
using Autofac.Integration.Mvc;
using LojaSporteVirtual.CrossCorting.DependenciModels;
using System.Web.Mvc;

namespace LojaEsporeVirtual.Web.Helps
{
    public class InejctoIoC
    {
        public static void RegistroDeDependencias()
        {
            var builder = new ContainerBuilder();
            var RepositoryDependencia = typeof(RepositoryDependenciInjector).Assembly;
            var ApllicationDependencia = typeof(ApplicationDependenciInjector).Assembly;
            var ServiceDependencia = typeof(ServiceDependenciInjector).Assembly;
            builder.RegisterAssemblyModules(ApllicationDependencia);
            builder.RegisterAssemblyModules(ServiceDependencia);
            builder.RegisterControllers(typeof(MvcApplication).Assembly).InstancePerRequest();
            builder.RegisterModelBinders(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinderProvider();
            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}