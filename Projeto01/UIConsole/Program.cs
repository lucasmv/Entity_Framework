using Aplicacao;
using Dominio.Entities;
using System;
using System.Collections.Generic;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var appProduto = new ProdutoApp();
            var appCategoria = new CategoriaApp();
            var appListaDeProduto = new ListaDeProdutoApp();

            //var categoria1 = new Categoria();
            //categoria1.Descricao = "Enlatado";

            //var categoria2 = new Categoria();
            //categoria2.Descricao = "Alimento";

            //appCategoria.Insert(categoria1);
            //appCategoria.Insert(categoria2);

            //var produto1 = new Produto
            //{
            //    CategoriaId = 1,
            //    Nome = "Oleo"
            //};

            //var produto2 = new Produto
            //{
            //    CategoriaId = 2,
            //    Nome = "Arroz"
            //};

            //var produto3 = new Produto
            //{
            //    CategoriaId = 2,
            //    Nome = "Feijão"
            //};

            //appProduto.Insert(produto1);
            //appProduto.Insert(produto2);
            //appProduto.Insert(produto3);

            //var todosOsProdutos = new ListaDeProduto();

            //todosOsProdutos.Descricao = "Lista com todos os produtos";
            //todosOsProdutos.Produtos = (ICollection<Produto>)appProduto.GetAll();

            //appListaDeProduto.Insert(todosOsProdutos);




            var listas = appListaDeProduto.GetAll();

            foreach (var lista in listas)
            {
                Console.WriteLine("{0} = {1}", lista.Id, lista.Descricao);
                Console.WriteLine("");

                foreach (var produto in lista.Produtos)
                    Console.WriteLine(produto.ToString());

                Console.WriteLine("-------------------------------------------");
            }

            var categorias = appCategoria.GetAll();
            foreach (var item in categorias)
                Console.WriteLine(item.ToString());

            Console.WriteLine("");

            var produtos = appProduto.GetAll();
            foreach (var item in produtos)
                Console.WriteLine(item.ToString());

            Console.ReadKey();
        }
    }
}
