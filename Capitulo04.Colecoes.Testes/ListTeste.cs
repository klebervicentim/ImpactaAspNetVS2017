using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Oficina.Dominio;

namespace Capitulo04.Colecoes.Testes
{
    [TestClass]
    public class ListTeste
    {
        [TestMethod]
        public void InicializacaoTeste()
        {
            var inteiros = new List<int>() {0, 9, 4, 1 };
            inteiros.Add(14);
            inteiros.Add(3);

            var inteiro = inteiros[0];
            //Resgata um valor de um indice

            var maisInteiros = new List<int>() { 1, 8, 2, 0 };
            inteiros.AddRange(maisInteiros);
            //AddRange adiciona uma lista na outra

            inteiros.Insert(0, 52);
            //Insert coloca o valor "52" no indice "0" e empurra todo mundo pra frente

            inteiros.Remove(3);
            //Esse metodo remove O CONTEÚDO PASSADO 

            inteiros.RemoveAt(4);
            //Esse metodo remove um elemento passando o Indice

            inteiros.Sort();

            var primeiro = inteiros[0];
            var ultimo = inteiros[inteiros.Count -1];

            foreach (var numero in inteiros)
            {
                Console.WriteLine("Indice é {0} e valor é {1}", inteiros.IndexOf(numero), numero);
            }
            
        }

        [TestMethod]
        public void DictionaryTeste()
        {
            var feriados = new Dictionary<DateTime, string>();
            //var veiculos = new Dictionary<string, Veiculo>();

            feriados.Add(new DateTime(2018,12,25), "Natal");
            feriados.Add(Convert.ToDateTime("31/12/2018"), "Reveillon");
            feriados.Add(Convert.ToDateTime("25/01/2018"), "Aniversario de SP");

            var nomeDoFeriado = feriados[new DateTime(2018,12,25)];

            foreach (var feriado in feriados)
            {
                Console.WriteLine($"{feriado.Key.ToString("dd/MM/yyyy")} : {feriado.Value}");
            }

            Console.WriteLine(feriados.ContainsKey(Convert.ToDateTime("31/12/2018")));

            Console.WriteLine(feriados.ContainsValue("Meu niver"));
        }
    }
}
