using AgileTickets.Web.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests.Models
{
    [TestFixture]
    public class EspetaculoTest
    {
        [Test]
        public void CriaSessoesDeveRetornarIListDeSessao()
        {
            var espetaculo = new Espetaculo();
            var inicio = new DateTime(2014, 05, 22);
            var fim = new DateTime(2014, 05, 25);
            var peridiocidade = Periodicidade.DIARIA;

            var listaDeSessoes = espetaculo.CriaSessoes(inicio, fim, peridiocidade);

            Assert.IsInstanceOf(typeof(IList<Sessao>), listaDeSessoes);
        }

        [Test]
        public void CriaSessoesDeveCriar3SessoesCasoOEspetaculoSejaDiarioPor3Dias()
        {
            var espetaculo = new Espetaculo();
            var inicio = new DateTime(2014, 05, 22);
            var fim = new DateTime(2014, 05, 24);
            var peridiocidade = Periodicidade.DIARIA;

            var listaDeSessoes = espetaculo.CriaSessoes(inicio, fim, peridiocidade);

            Assert.AreEqual(3, listaDeSessoes.Count);
        }
    }
}
