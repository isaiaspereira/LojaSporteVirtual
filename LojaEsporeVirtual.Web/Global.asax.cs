using Autofac;
using Autofac.Integration.Mvc;
using LojaEsporeVirtual.Web.Helps;
using LojaEsporeVirtual.Web.Models;
using LojaSporteVirtual.Domain.Entity;
using LojaSporteVirtual.Domain.Entity.Interface;
using LojaSporteVirtual.Repositorie.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LojaEsporeVirtual.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {

        protected void Application_Start()
        {
            InejctoIoC.RegistroDeDependencias();
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
