using Loja.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace Loja.Repositorios.SqlServer.EFCodeFirst.ModelConfiguration
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            Property(p => p.Nome).HasMaxLength(200).IsRequired();

            Property(p => p.Preco).HasPrecision(9, 2);

            HasRequired(p => p.Categoria);
        }
    }
}