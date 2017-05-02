using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace UIConsole
{
    public class CategoriaApp
    {
        public Context db { get; set; }

        public CategoriaApp()
        {
            db = new Context();
        }

        public void Salvar(Categoria categoria)
        {
            db.Categorias.Add(categoria);
            db.SaveChanges();
        }

        public IEnumerable<Categoria> Listar()
        {
            return db.Categorias.OrderBy(x => x.Descricao);
        }

        public void Alterar(Categoria categoria)
        {
            db.Entry(categoria).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Excluir(int id)
        {
            var categoria = db.Categorias.Find(id);

            db.Categorias.Remove(categoria);
            db.SaveChanges();
        }
    }
}
