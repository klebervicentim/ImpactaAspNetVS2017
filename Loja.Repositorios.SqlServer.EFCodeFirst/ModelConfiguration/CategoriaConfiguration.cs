using Loja.Dominio;
using System.Data.Entity.ModelConfiguration;

namespace Loja.Repositorios.SqlServer.EFCodeFirst
{
    public class CategoriaConfiguration : EntityTypeConfiguration<Categoria>
    {
        public CategoriaConfiguration()
        {
            Property(c => c.Nome).HasMaxLength(50).IsRequired();
        }
    }
}