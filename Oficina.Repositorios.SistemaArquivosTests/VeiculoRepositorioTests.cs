using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class VeiculoRepositorioTests
    {
        VeiculoRepositorio _repositorio = new VeiculoRepositorio();
        
        
        [TestMethod()]
        public void InserirTest()
        {
            Veiculo veiculo = new Veiculo();
            veiculo.Ano = 2017;
            veiculo.Cambio = Cambio.Manual;
            veiculo.Combustivel = Combustivel.Gasolina;
            veiculo.Cor = new CorRepositorio().Selecionar(2);
            veiculo.Id = 2;
            veiculo.Modelo = new ModeloRepositorio().SelecionarPorId(1);
            veiculo.Placa = "MRV0400";
            veiculo.Observacao = "Segundo carro";

            _repositorio.Inserir(veiculo);
        }
    }
}