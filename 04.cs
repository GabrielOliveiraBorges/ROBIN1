using System;

class Program
{
    static void Main(string[] args)
    {
        Produto produto = new Produto();

        Console.Write("Informe o nome do produto: ");
        produto.Nome = Console.ReadLine();

        Console.Write("Informe o preço do produto: ");
        produto.Preco = double.Parse(Console.ReadLine());

        int opcao = 0;

        do
        {
            Console.WriteLine("\n==== MENU ESTOQUE ====");
            Console.WriteLine("1. Adicionar estoque");
            Console.WriteLine("2. Remover estoque");
            Console.WriteLine("3. Ver valor total em estoque");
            Console.WriteLine("4. Ver quantidade total");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Quantidade a adicionar: ");
                    int add = int.Parse(Console.ReadLine());
                    produto.AdicionarEstoque(add);
                    break;

                case 2:
                    Console.Write("Quantidade a remover: ");
                    int rem = int.Parse(Console.ReadLine());
                    produto.RemoverEstoque(rem);
                    break;

                case 3:
                    Console.WriteLine($"Valor total em estoque: R$ {produto.ValorTotalEmEstoque():F2}");
                    break;

                case 4:
                    Console.WriteLine($"Quantidade total em estoque: {produto.QuantidadeTotal}");
                    break;

                case 0:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (opcao != 0);
    }
}