using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;
using System.Xml.Linq;
using System.Collections.Generic;
using System;
using System.Configuration;


public class VeiculoRepositorio
{
    private string _caminhoArquivoVeiculo =  ConfigurationManager.AppSettings["caminhoArquivoVeiculo"];
    public void Inserir(Veiculo veiculo)
    {
     var veiculos = XDocument.Load(_caminhoArquivoVeiculo); 
     var registro = new StringWriter(); 
     new xmlSerializer(typeof(Veiculo)).serialize(registro, veiculo);

     veiculos.Root.Add(XElement.Parse(registro.ToString()));

     var veiculos.Save(_caminhoArquivoVeiculo); 

        
    }
}