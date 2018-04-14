using System;
using System.Collections.Generic;
using System.Data.Entity;
using Loja.Dominio;

namespace Loja.Repositorios.SqlServer.EFCodeFirst
{
    internal class LojaDbInitializer : DropCreateDatabaseIfModelChanges<LojaDbContext>
    {
        protected override void Seed(LojaDbContext context)
        {
            context.Produtos.AddRange(ObterProdutos());

            context.SaveChanges();
        }

        private IEnumerable<Produto> ObterProdutos()
        {
            var grampeador = new Produto();
            grampeador.Categoria = new Categoria() { Nome = "Papelaria" };
            grampeador.Ativo = false;
            grampeador.Estoque = 38;
            grampeador.Nome = "Grampeador";
            grampeador.Preco = 3.85m;

            var pendrive = new Produto();
            pendrive.Categoria = new Categoria() { Nome = "Informática" };
            pendrive.Ativo = false;
            pendrive.Estoque = 15;
            pendrive.Nome = "Pen Drive 32GB";
            pendrive.Preco = 25.0m;

            return new List<Produto> { grampeador, pendrive };

        }
    }
}