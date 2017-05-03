using System.Collections.Generic;

namespace Dominio.Entities
{
    public class Categoria
    {
        public long Id { get; set; }
        public string Descricao { get; set; }

        public virtual IEnumerable<Produto> Produtos { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Id, Descricao);
        }
    }
}
