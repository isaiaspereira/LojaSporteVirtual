using Autofac;
using LojaSporteVirtual.Application.Interface;
using LojaSporteVirtual.Application.Service;
using LojaSporteVirtual.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaSporteVirtual.CrossCorting.DependenciModels
{
   public class ApplicationDependenciInjector:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType(typeof(ApplicationBase<Produto>)).As(typeof(IApplicationBase<Produto>)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(ApplicationBase<Categoria>)).As(typeof(IApplicationBase<Categoria>)).InstancePerLifetimeScope();


            builder.RegisterType<ProdutoApplication>().As<IProdutoApplication>().InstancePerRequest();
            builder.RegisterType<CategoriaApplication>().As<ICategoriaApplication>().InstancePerRequest();

        }
    }
}
