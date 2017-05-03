using Dominio.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Repositorio.EntityConfig
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {
            HasKey(x => x.Id);
            HasRequired(x => x.Categoria);
            HasMany(x => x.ListaDeProdutos);

            Property(x => x.Nome).HasMaxLength(150).IsRequired();
        }
    }
}
