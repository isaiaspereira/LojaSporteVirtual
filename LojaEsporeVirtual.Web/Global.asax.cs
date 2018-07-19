using LojaEsporeVirtual.Web.Helps;
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
