using Dominio.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Repositorio.EntityConfig
{
    public class ListaDeProdutoConfig : EntityTypeConfiguration<ListaDeProduto>
    {
        public ListaDeProdutoConfig()
        {
            HasKey(x => x.Id);

            HasMany(x => x.Produtos)
                .WithMany(x => x.ListaDeProdutos)
                .Map(x => x.ToTable("ProdutosNaListaDeProdutos"));

            Property(x => x.Descricao).HasMaxLength(150).IsRequired();
        }
    }
}
