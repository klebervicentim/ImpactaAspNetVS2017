using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;
using System.Xml.Linq;
using System.Collections.Generic;
using System;
using System.Configuration;


public class ModeloRepositorio
{

    public List <Modelo> SelecionarPorMarca(int marcaId)
    {
        var modelos = new List<Modelo>();
        var arquivoXml = XDocument.Load(ConfigurationManager.AppSettings["caminhoArquivoModelo"]);

        foreach (var elemento in arquivoXml.Descendants("modelo"))
        {
            if (marcaId.ToString() == elemento.Element("marcaId").Value)
            {
                Modelo modelo = new Modelo();

                modelo.Id =   Convert.ToInt32(elemento.Element("id").Value);
                modelo.Nome = Convert.ToInt32(elemento.Element("nome").Value);
                modelo.Marca = new MarcaRepositorio().Selecionar(marcaId);

                modelos.Add(modelo);
            }
            
        }

        return modelos;
    }

}