using System;
using System.Web;

using System.Linq;
using LojaEsporeVirtual.Web.Helps;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace MinhaPrimeiraLoja.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Take()
        {
            //exemplo usuando o operador Take em uma query
            int[] Numeros = { 5, 3, 6, 9, 8, 1, 4, 7 };
            var resultado = from num in Numeros.Take(5) select num;
            int[] Test = { 5, 3, 6, 9, 8 };
            CollectionAssert.AreEqual(resultado.ToArray(), Test);
        }

        [TestMethod]
        public void Skip()
        {
            //exemplo usuando o operador Take em uma query
            int[] Numeros = { 5, 3, 6, 9, 8, 1, 4, 7 };
            var resultado = from num in Numeros.Take(5).Skip(2) select num;
            int[] Test = { 6, 9, 8 };
            CollectionAssert.AreEqual(resultado.ToArray(), Test);
        }


        //Teste efetuado o TDD com tipo AAA(Arrange,Act,Assert)
        [TestMethod]
        public void TestarSeAPaginacaoEstaSendoGeradaCorretamente()
        {
            //Primeiramente Efetuar o Arrange ou seja setar as variaveis
            HtmlHelper helper = null;

            Paginacao paginacao = new Paginacao
            {
                PaginaAtual = 2,
                ItensPorPagina = 10,
                ItensTotal = 28
            };
            Func<int, string> PaginaUrl = i => "Pagina" + i;

            //Act

            MvcHtmlString resultado = helper.PageLinks(paginacao, PaginaUrl);

            //Assert

            Assert.AreEqual(

                @"<a class=""btn btn-default"" href=""Pagina1"">1</a>"
                + @"<a class=""btn btn-default  btn-primary selected"" href=""Pagina2"">2</a>"
                + @"<a class=""btn btn-default"" href=""Pagina3"">3</a>"
                , resultado.ToString()
                );
        }
    }
}
