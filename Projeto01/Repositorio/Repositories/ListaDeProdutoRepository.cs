using Dominio.Entities;
using Dominio.Interfaces;
using Repositorio.Contexto;
using System.Linq;

namespace Repositorio.Repositories
{
    public class ListaDeProdutoRepository : RepositoryBase<ListaDeProduto>, IListaDeProdutoRepository
    {

        public override void Insert(ListaDeProduto listaDeProduto)
        {
            listaDeProduto.Produtos = listaDeProduto.Produtos.Select(produto => m_Context.Produtos.FirstOrDefault(x => x.Id == produto.Id)).ToList();

            m_Context.ListaDeProdutos.Add(listaDeProduto);
            m_Context.SaveChanges();
        }

        public override void Update(ListaDeProduto listaDeProduto)
        {
            var listaSalvar = m_Context.ListaDeProdutos.Find(listaDeProduto.Id);

            listaSalvar.Produtos = listaDeProduto.Produtos.Select(produto => m_Context.Produtos.FirstOrDefault(x => x.Id == produto.Id)).ToList();
            listaSalvar.Descricao = listaDeProduto.Descricao;

            m_Context.SaveChanges();
        }
    }
}
