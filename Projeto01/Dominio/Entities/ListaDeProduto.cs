using System.Collections.Generic;

namespace Dominio.Entities
{
    public class ListaDeProduto
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}
