using System.Collections.Generic;
using Dominio.Entities;
using Dominio.Interfaces;
using System.Data.Entity;
using System.Linq;

namespace Repositorio.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public override IEnumerable<Produto> GetAll()
        {
            return m_Context.Produtos.Include(x => x.Categoria).ToList();
        }
    }
}
