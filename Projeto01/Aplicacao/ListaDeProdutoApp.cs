using Dominio.Entities;
using Repositorio.Repositories;
using System.Collections.Generic;

namespace Aplicacao
{
    public class ListaDeProdutoApp
    {
        private ListaDeProdutoRepository repository { get; set; }

        public ListaDeProdutoApp()
        {
            repository = new ListaDeProdutoRepository();
        }

        public void Insert(ListaDeProduto listaDeProduto)
        {
            repository.Insert(listaDeProduto);
        }

        public ListaDeProduto GetById(long id)
        {
            return repository.GetById(id);
        }

        public IEnumerable<ListaDeProduto> GetAll()
        {
            return repository.GetAll();
        }

        public void Update(ListaDeProduto listaDeProduto)
        {
            repository.Update(listaDeProduto);
        }

        public void Remove(int id)
        {
            var listaExcluir = repository.GetById(id);

            repository.Remove(listaExcluir);
        }
    }
}
