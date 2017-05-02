using System;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var appProduto = new ProdutoApp();
            var appCategoria = new CategoriaApp();
            var appListaDeProduto = new ListaDeProdutoApp();


            var listas = appListaDeProduto.Listar();

            foreach (var lista in listas)
            {
                Console.WriteLine("{0} = {1}", lista.Id, lista.Descricao);
                Console.WriteLine("");

                foreach (var produto in lista.Produtos)
                    Console.WriteLine(produto.ToString());

                Console.WriteLine("-------------------------------------------");
            }

            //var produtos = appCategoria.Listar();
            //foreach (var item in produtos)
            //    Console.WriteLine(item.ToString());

            //Console.WriteLine("");

            //var categorias = appProduto.Listar();
            //foreach (var item in categorias)
            //    Console.WriteLine(item.ToString());

            Console.ReadKey();
        }
    }
}
