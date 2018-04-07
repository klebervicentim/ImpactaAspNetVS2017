using Microsoft.VisualStudio.TestTools.UnitTesting;
using Loja.Repositorios.SqlServer.EFCodeFirst;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.Dominio;
using System.Diagnostics;

namespace Loja.Repositorios.SqlServer.EFCodeFirst.Tests
{
    [TestClass()]
    public class LojaDbContextTests
    {
        LojaDbContext _db = new LojaDbContext();

        public LojaDbContextTests()
        {
            _db.Database.Log = LogarQueries;
        }

        private void LogarQueries(string query)
        {
            Debug.Write(query);
        }

        [TestMethod()]
        public void LojaDbContextTest()
        {
            var categoria = new Categoria();
            categoria.Nome = "Mercearia";

            _db.Categorias.Add(categoria);
            _db.SaveChanges();

        }
        [TestMethod]
        public void InserirProdutoTeste()
        {
            var produto = new Produto();
            produto.Nome = "Banana";
            produto.Preco = 2.4m;
            produto.Estoque = 25;

            produto.Categoria = _db.Categorias.Where(c => c.Nome == "Mercearia").First();

            _db.Produtos.Add(produto);
            _db.SaveChanges();
        }

        [TestMethod]
        public void InserirComNovaCategoriaTeste()
        {
            var produto = new Produto();
            produto.Nome = "Celular";
            produto.Preco = 1085.60m;
            produto.Estoque = 18;

            produto.Categoria = new Categoria { Nome = "Eletronicos" };

            _db.Produtos.Add(produto);
            _db.SaveChanges();
        }

        [TestMethod]
        public void EditarProdutoTeste()
        {
            var produto = (from p in _db.Produtos
                          where p.Nome == "Celular"
                          select p).First();

            produto.Preco = 2000.00m;
            produto.Nome = "Celular mais caro";

            _db.SaveChanges();            
        }

        [TestMethod]
        public void ExcluirProdutoTeste()
        {
            var produto = (from p in _db.Produtos
                           where p.Nome == "Celular mais caro"
                           select p).First();

            _db.Produtos.Remove(produto);
            _db.SaveChanges();

        }

        [TestMethod]
        public void LazyLoadDesligadoTeste()
        {
            var produto = (from p in _db.Produtos
                           where p.Nome == "Banana"
                           select p).First();

            Assert.IsNull(produto.Categoria);   
        }

        [TestMethod]
        public void IncludeTeste()
        {
            var produto = _db.Produtos.Include(p => p.Categoria).Single(p => p.Id == 1);
            Assert.IsTrue(produto.Categoria.Nome == "Mercearia");

        }

        [TestMethod]
        public void QueriableTeste()
        {
            var query = _db.Produtos.Where(p => p.Preco < 10);
        }


    }
}