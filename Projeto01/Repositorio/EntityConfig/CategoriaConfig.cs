using Dominio.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Repositorio.EntityConfig
{
    public class CategoriaConfig : EntityTypeConfiguration<Categoria>
    {
        public CategoriaConfig()
        {
            HasKey(x => x.Id);

            Property(x => x.Descricao).HasMaxLength(150).IsRequired();
        }
    }
}
