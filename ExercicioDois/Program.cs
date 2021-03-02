using System;
using System.Globalization;

namespace ExercicioDois
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------Entre com os dados do produto-----------");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int qtd = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, qtd);

            Console.WriteLine(); 
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a serem adicionados ao estoque.");
            int qte = int.Parse(Console.ReadLine());

            p.AddProduto(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a serem removidos ao estoque.");
            qte = int.Parse(Console.ReadLine());

            p.RemoverProduto(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);


        }
    }
}
