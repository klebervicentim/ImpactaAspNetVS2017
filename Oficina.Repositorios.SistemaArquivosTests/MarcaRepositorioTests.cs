using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class MarcaRepositorioTests
    {

        MarcaRepositorio repositorio = new MarcaRepositorio();
        

        [TestMethod()]
        public void SelecionarTest()
        {

            var marcas = repositorio.Selecionar();
            foreach (var marca in marcas)
            {
                Console.WriteLine($"{ marca.Id} - { marca.Nome }");
            }

        }

        [TestMethod()]
        [DataRow(1)]
        [DataRow(-1)]
        public void SelecionarPorID(int marcaSelecionada)
        {
            var marca = repositorio.Selecionar(marcaSelecionada);
            var marcas = repositorio.Selecionar();

            if (marcaSelecionada>0)
            {
                Assert.IsNotNull(marca);
            }
            else
            {
                Assert.IsNull(marca);
            }

        }
    }
}