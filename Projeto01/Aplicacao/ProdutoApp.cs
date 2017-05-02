using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace UIConsole
{
    public class ProdutoApp
    {
        public Context db { get; set; }

        public ProdutoApp()
        {
            db = new Context();
        }

        public void Salvar(Produto produto)
        {
            if (produto.Categoria != null)
                produto.Categoria = db.Categorias.Where(x => x.Id == produto.Categoria.Id).FirstOrDefault();

            db.Produtos.Add(produto);
            db.SaveChanges();
        }

        public IEnumerable<Produto> Listar()
        {
            return db.Produtos.Include(x => x.Categoria).OrderBy(x => x.Nome);
        }

        public void Alterar(Produto produto)
        {
            db.Entry(produto).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Excluir(int id)
        {
            var produto = db.Produtos.Where(x => x.Id == id).First();
            db.Produtos.Remove(produto);
            //db.Set<Produto>().Remove(produto);
            db.SaveChanges();
        }

    }
}
