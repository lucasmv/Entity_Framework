using Dominio.Entities;
using Dominio.Interfaces;
using Repositorio.Contexto;

namespace Repositorio.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
    }
}
