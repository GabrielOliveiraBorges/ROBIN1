using System;

namespace EstoqueLoja
{
    public class Produto
    {
        public string Nome;          
        public double Preco;        
        public int QuantidadeTotal;  

        public void AdicionarEstoque(int quantidade)
        {
            if (quantidade > 0)
            {
                QuantidadeTotal += quantidade;
            }
        }

        public void RemoverEstoque(int quantidade)
        {
            if (quantidade > 0 && quantidade <= QuantidadeTotal)
            {
                QuantidadeTotal -= quantidade;
            }
            else
            {
                Console.WriteLine("Não tem estoque suficiente para remover.");
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * QuantidadeTotal;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();  

            Console.WriteLine("Digite o nome do produto:");
            produto.Nome = Console.ReadLine();  

            Console.WriteLine("Digite o preço do produto:");
            produto.Preco = double.Parse(Console.ReadLine());  

            Console.WriteLine("Digite a quantidade inicial em estoque:");
            produto.QuantidadeTotal = int.Parse(Console.ReadLine());  

            produto.AdicionarEstoque(10);
            Console.WriteLine($"Produto: {produto.Nome}");
            Console.WriteLine($"Quantidade em estoque após adicionar 10: {produto.QuantidadeTotal}");

            produto.RemoverEstoque(5);
            Console.WriteLine($"Quantidade em estoque após remover 5: {produto.QuantidadeTotal}");

            Console.WriteLine($"Valor total em estoque: R$ {produto.ValorTotalEmEstoque():F2}");

            Console.WriteLine("Programa finalizado.");
        }
    }
}
