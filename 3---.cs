using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Cadastro de Funcionário ou Gerente");
        Console.Write("Digite F para Funcionário ou G para Gerente: ");
        string tipo = Console.ReadLine().ToUpper();

        if (tipo == "F")
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Nome completo: ");
            funcionario.NomeCompleto = Console.ReadLine();

            Console.Write("Salário: ");
            funcionario.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("\n--- Dados do Funcionário ---");
            funcionario.ExibirDados();
        }
        else if (tipo == "G")
        {
            Gerente gerente = new Gerente();

            Console.Write("Nome completo: ");
            gerente.NomeCompleto = Console.ReadLine();

            Console.Write("Salário: ");
            gerente.Salario = double.Parse(Console.ReadLine());

            Console.Write("Departamento: ");
            gerente.Departamento = Console.ReadLine();

            Console.WriteLine("\n--- Dados do Gerente ---");
            gerente.ExibirDados();
        }
        else
        {
            Console.WriteLine("Opção inválida!");
        }
    }
}
