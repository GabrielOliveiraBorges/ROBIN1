using System;

public class Calculadora
{
    private Calculo calculo = new Calculo();

    public void LerValores()
    {
        Console.Write("Digite o primeiro valor (ValorA): ");
        calculo.ValorA = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor (ValorB): ");
        calculo.ValorB = double.Parse(Console.ReadLine());
    }

    public void ExecutarCalculadora()
    {
        LerValores();
        int opcao;

        do
        {
            Console.WriteLine("\n--- Menu da Calculadora ---");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Maior Valor");
            Console.WriteLine("5 - Somar Geral com outro número");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    calculo.CalcularSoma();
                    calculo.ImprimirResultado();
                    break;
                case 2:
                    calculo.CalcularSubtracao();
                    calculo.ImprimirResultado();
                    break;
                case 3:
                    calculo.CalcularMultiplicacao();
                    calculo.ImprimirResultado();
                    break;
                case 4:
                    Console.WriteLine($"Maior valor: {calculo.RetornarMaior()}");
                    break;
                case 5:
                    Console.Write("Digite um valor adicional: ");
                    double valorExtra = double.Parse(Console.ReadLine());
                    double somaGeral = calculo.SomarGeral(valorExtra);
                    Console.WriteLine($"Soma geral: {somaGeral}");
                    break;
                case 0:
                    Console.WriteLine("Encerrando...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (opcao != 0);
    }
}
