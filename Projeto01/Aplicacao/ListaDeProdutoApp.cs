using Dominio.Entities;
using Repositorio.Contexto;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Aplicacao
{
    public class ListaDeProdutoApp
    {
        public Context db { get; set; }

        public ListaDeProdutoApp()
        {
            db = new Context();
        }

        public void Salvar(ListaDeProduto listaDeProduto)
        {
            listaDeProduto.Produtos = listaDeProduto.Produtos.Select(produto => db.Produtos.FirstOrDefault(x => x.Id == produto.Id)).ToList();

            db.ListaDeProdutos.Add(listaDeProduto);
            db.SaveChanges();
        }

        public IEnumerable<ListaDeProduto> Listar()
        {
            return db.ListaDeProdutos
                    .Include(x => x.Produtos)
                    .Include(x => x.Produtos.Select(c => c.Categoria));
        }

        public void Alterar(ListaDeProduto listaDeProduto)
        {
            var listaSalvar = db.ListaDeProdutos.Find(listaDeProduto.Id);

            listaSalvar.Produtos = listaDeProduto.Produtos.Select(produto => db.Produtos.FirstOrDefault(x => x.Id == produto.Id)).ToList();
            listaSalvar.Descricao = listaDeProduto.Descricao;

            db.SaveChanges();

        }

        public void Excluir(int id)
        {
            var listaExcluir = db.ListaDeProdutos.Find(id);

            db.ListaDeProdutos.Remove(listaExcluir);
            db.SaveChanges();
        }
    }
}
