using Dominio.Entities;
using Repositorio.Contexto;
using Repositorio.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Aplicacao
{
    public class ProdutoApp
    {
        private ProdutoRepository repository { get; set; }

        public ProdutoApp()
        {
            repository = new ProdutoRepository();
        }

        public void Insert(Produto produto)
        {
            repository.Insert(produto);
        }

        public Produto GetById(long id)
        {
            return repository.GetById(id);
        }

        public IEnumerable<Produto> GetAll()
        {
            return repository.GetAll();
        }

        public void Update(Produto produto)
        {
            repository.Update(produto);
        }

        public void Excluir(long id)
        {
            var produto = repository.GetById(id);
            repository.Remove(produto);

        }

    }
}
