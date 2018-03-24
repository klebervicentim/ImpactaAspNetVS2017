using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;

namespace Capitulo04.Colecoes.Testes
{
    [TestClass]
    public class VetorTeste
    {
        [TestMethod]
        public void InicializacaoTeste()
        {
            //var Strings = new string[10];
            //Strings[1] = "Nova string 1";
            //Strings[9] = "String numero 9";

            //var veiculos = new VeiculoPasseio[14000];

            decimal[] Decimais = { 12.4m, 11.3m, 5 };

            foreach (var @decimal in Decimais)
            {
                Console.WriteLine(@decimal);
            }

            Console.WriteLine($"Tamanho do vetor = {Decimais.Length}");
        }

        [TestMethod]
        public void RedimensionamentoTeste()
        {
            decimal[] Decimais = { 2.8m, 6.5m, 10 };
            Array.Resize(ref Decimais, 4);
            Decimais[3] = 17.8m;
        }

        [TestMethod]
        public void OrdenacaoTeste()
        {
            decimal[] Decimais = { 2.8m, 6.5m, 10 };
            Array.Sort(Decimais);
            Assert.IsTrue(Decimais[0] == 2.8m);

        }

        public decimal CalculaMedia(decimal valor1, decimal valor2)
        {
            //valor1 = 2.5m;
            //valor2 = 10.9m;

            return (valor1 + valor2) / 2;
        }
        public decimal CalculaMedia(params decimal[] valores)
        {
            decimal somaTotal = 0m;
            foreach (var item in valores)
            {
                somaTotal += item;
            }
            return somaTotal / valores.Length;
        }

        [TestMethod]
        public void MediaTeste()
        {
            decimal[] Decimais = { 2.8m, 6.5m, 10 };
            Console.WriteLine(CalculaMedia(Decimais));
            
        }

        [TestMethod]
        public void StringsSaoVetoresTeste()
        {
            var nome = "Vitor";

            foreach (var caracter in nome)
            {
                Console.WriteLine(caracter);
            }

        }

        private decimal Media(decimal valor1, decimal valor2)
        {
            return 0;
        }
        //ToDo: Copiar esse código

        private decimal Media2(params decimal[] valores)
        {
            return 0;
        }
        //ToDo: Copiar esse código
    }
}
