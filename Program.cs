using System;
using System.Globalization;
using ProdutosEstoque;


namespace SistemaEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //Produto p = new Produto();

            System.Console.WriteLine("Entre os dados do produto: ");
            System.Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

            System.Console.WriteLine();
            System.Console.WriteLine("Dados do Produto: " + p );

            System.Console.WriteLine();
            System.Console.Write("Digite o numero de produtos a ser adicionados em estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
           
            System.Console.WriteLine();
            System.Console.WriteLine("Dados atualizados: " + p);

            System.Console.WriteLine();
            System.Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            
            System.Console.WriteLine();
            System.Console.WriteLine("Dados atualizados: " + p);

        }
    }
}