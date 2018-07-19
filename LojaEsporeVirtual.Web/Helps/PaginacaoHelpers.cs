using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using System.Web.Mvc;

namespace LojaEsporeVirtual.Web.Helps
{
    public static class PaginacaoHelpers
    {
        public static MvcHtmlString PageLinks(this HtmlHelper helper, Paginacao paginacao,Func<int,string> paginaUrl)
        {
            StringBuilder resultado = new StringBuilder();

            for (int i = 1; i <= paginacao.TotalDePagina; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", paginaUrl(i));
                tag.InnerHtml = i.ToString();
                if (i==paginacao.PaginaAtual)
                {
                    tag.AddCssClass("Selected");
                    tag.AddCssClass(" btn-primary");
                }
                tag.AddCssClass("btn btn-default");
                resultado.Append(tag);
            }

            return MvcHtmlString.Create(resultado.ToString());
        }
    }
}