using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Oficina.AspNet
{
    public class VeiculoAplicacao
    {
        private CorRepositorio _corRepositorio = new CorRepositorio();
        private MarcaRepositorio _marcaRepositorio = new MarcaRepositorio();
        private ModeloRepositorio _modeloRepositorio = new ModeloRepositorio();
        private VeiculoRepositorio _veiculoRepositorio = new VeiculoRepositorio();
       
        public VeiculoAplicacao()
        {
            PopularControles();
        }

        public List<Marca> Marcas { get; private set; }
        public string MarcaSelecionada { get; private set; }
        public List<Modelo> Modelos { get; private set; } = new List<Modelo>();
        public List<Cor> Cores { get; private set; }
        public List<Combustivel> Combustiveis { get; private set; }
        public List<Cambio> Cambios { get; private set; }

        private void PopularControles()
        {
            Marcas = _marcaRepositorio.Selecionar();

            MarcaSelecionada = HttpContext.Current.Request.QueryString["marcaId"];

         if (!string.IsNullOrEmpty(MarcaSelecionada))
            Modelos = _modeloRepositorio.SelecionarPorMarca(Convert.ToInt32(MarcaSelecionada));

            Cores = _corRepositorio.Selecionar();

            Combustiveis = Enum.GetValues(typeof(Combustivel)).Cast<Combustivel>().ToList();

            Cambios = Enum.GetValues(typeof(Cambio)).Cast<Cambio>().ToList();
        }

        public void Inserir()
        {
            try
            {
                var veiculo = new VeiculoPasseio();
                var formulario = HttpContext.Current.Request.Form;

                veiculo.Ano = Convert.ToInt32(formulario["ano"]);
                veiculo.Cambio = (Cambio)Convert.ToInt32(formulario["cambio"]);
                veiculo.Combustivel = (Combustivel)Convert.ToInt32(formulario["combustivel"]);
                veiculo.Cor = _corRepositorio.Selecionar(Convert.ToInt32(formulario["cor"]));
                veiculo.Modelo = _modeloRepositorio.SelecionarPorId(Convert.ToInt32(formulario["modelo"]));
                veiculo.Placa = formulario["placa"];
                veiculo.Observacao = formulario["observacao"];
                veiculo.Carroceria = TipoCarroceria.Hatch;

                _veiculoRepositorio.Inserir(veiculo);
            }
            catch (FileNotFoundException ex)
            {
                HttpContext.Current.Items.Add("mensagemErro", $"Arquivo {ex.FileName} não encontrado");
                //logar o objeto de exception ex
                throw;
            }
            catch (UnauthorizedAccessException ex)
            {
                HttpContext.Current.Items.Add("mensagemErro", "Acesso negado à base de dados");
                //logar o objeto de exception ex
                throw;
            }
            catch (DirectoryNotFoundException ex)
            {
                HttpContext.Current.Items.Add("mensagemErro", "Verifique se a unidade de rede está conectada");
                //logar o objeto de exception ex
                throw;
                
            }
            catch (Exception ex)
            {
                HttpContext.Current.Items.Add("mensagemErro", "Deu ruim!");
                //logar o objeto de exception ex
                throw;
            }
            finally
            {
                //Chamado sempre independente de erro ou sucesso
                //É executado mesmo que haja um return 
            }

        }
    }
}