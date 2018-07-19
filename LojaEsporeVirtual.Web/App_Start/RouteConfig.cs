using System.Web.Mvc;
using System.Web.Routing;

namespace LojaEsporeVirtual.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            #region Rotas Da Categoria
            //1-Pagina a ser exibida

            routes.MapRoute(
                name: null,
                url: "",
                defaults: new
                {
                    controller = "Vitrine",
                    action = "ListaProduto",
                    categoria = (string)null,
                    pagina = @"\d+"
                });

            ////2-Segundo tipo de pagina a ser exibido.(ok)

            routes.MapRoute(
               name: null,
               url: "Pagina{pagina}",
               defaults: new
               {
                   controller = "Vitrine",
                   action = "ListaProduto",
                   categoria = (string)null
               },
               new { pagina = @"\d+" });

            //3-terceiro tipo de pagina a ser exibida(ok)

            routes.MapRoute(
                name: null,
                url: "{Categoria}",
                defaults: new
                {
                    controller = "Vitrine",
                    action = "ListaProduto",
                    pagina = 1
                });

            ////4-quarto tipo de pagina a ser exibida

            routes.MapRoute(
               name: null,
               url: "{Categoria}/Pagina{pagina}",
               defaults: new
               {
                   controller = "Vitrine",
                   action = "ListaProduto"
               },
               new { pagina = @"\d+" });

            #endregion

            //routes.MapRoute(
            //    name: null,
            //    url: "Pagina{pagina}",
            //    defaults: new { controller = "Vitrine", action = "ListaProduto",categoria=(string)null });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Produto", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
