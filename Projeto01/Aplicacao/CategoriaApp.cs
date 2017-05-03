using Dominio.Entities;
using Repositorio.Repositories;
using System.Collections.Generic;

namespace Aplicacao
{
    public class CategoriaApp
    {
        private CategoriaRepository repository { get; set; }

        public CategoriaApp()
        {
            repository = new CategoriaRepository();
        }

        public void Insert(Categoria categoria)
        {
            repository.Insert(categoria);
        }

        public Categoria GetById(long id)
        {
            return repository.GetById(id);
        }

        public IEnumerable<Categoria> GetAll()
        {
            return repository.GetAll();
        }

        public void Update(Categoria categoria)
        {
            repository.Update(categoria);
        }

        public void Excluir(long id)
        {
            var categoria = repository.GetById(id);

            repository.Remove(categoria);
        }
    }
}
