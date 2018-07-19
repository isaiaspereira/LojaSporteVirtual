using Autofac;
using Autofac.Integration.Mvc;
using LojaSporteVirtual.Domain.Entity;
using LojaSporteVirtual.Domain.Entity.Interface;
using LojaSporteVirtual.Repositorie;
using LojaSporteVirtual.Repositorie.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaEsporeVirtual.Web.Helps
{
    public class InejctoIoC
    {
        public static void RegistroDeDependencias()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly).InstancePerRequest();
            builder.RegisterType(typeof(RepositoryBase<Produto>)).As(typeof(IRepositoryBase<Produto>)).InstancePerLifetimeScope();
            builder.RegisterType<ProdutoRepository>().As<IProdutoRepository>().InstancePerRequest();
            builder.RegisterModelBinders(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinderProvider();
            builder.RegisterType(typeof(StrLojaVirtual)).InstancePerLifetimeScope();
            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}