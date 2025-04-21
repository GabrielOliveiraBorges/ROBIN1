using System;

public class Calculadora
{
    private Calculo calculo;

    public Calculadora()
    {
        calculo = new Calculo();
    }

    public void LerValores()
    {
        Console.Write("Digite o valor A: ");
        calculo.ValorA = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor B: ");
        calculo.ValorB = double.Parse(Console.ReadLine());
    }

    public void ExecutarCalculadora()
    {
        int opcao;

        do
        {
            Console.WriteLine("\n=== MENU CALCULADORA ===");
            Console.WriteLine("1 - Ler Novos Valores");
            Console.WriteLine("2 - Somar");
            Console.WriteLine("3 - Subtrair");
            Console.WriteLine("4 - Multiplicar");
            Console.WriteLine("5 - Retornar Maior Valor");
            Console.WriteLine("6 - Somar Geral com Valor Extra");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    LerValores();
                    break;
                case 2:
                    calculo.CalcularSoma();
                    calculo.ImprimirResultado();
                    break;
                case 3:
                    calculo.CalcularSubtracao();
                    calculo.ImprimirResultado();
                    break;
                case 4:
                    calculo.CalcularMultiplicacao();
                    calculo.ImprimirResultado();
                    break;
                case 5:
                    double maior = calculo.RetornarMaior();
                    Console.WriteLine($"Maior valor entre A e B: {maior}");
                    break;
                case 6:
                    Console.Write("Digite um valor extra para somar com A e B: ");
                    double extra = double.Parse(Console.ReadLine());
                    double somaTotal = calculo.SomarGeral(extra);
                    Console.WriteLine($"Resultado da soma geral: {somaTotal}");
                    break;
                case 0:
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (opcao != 0);
    }
}
