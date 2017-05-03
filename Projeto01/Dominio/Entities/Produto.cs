using System.Collections.Generic;

namespace Dominio.Entities
{
    public class Produto
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public long CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public virtual ICollection<ListaDeProduto> ListaDeProdutos { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", Id, Nome, Categoria.Descricao);
        }
    }
}
