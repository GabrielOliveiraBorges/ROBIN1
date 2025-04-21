using System;
using System.Globalization;

public class Gerente : Funcionario
{
    public string Departamento { get; set; }

    public override void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine($"Departamento: {Departamento}");

        if (Salario > 10000)
        {
            Console.WriteLine("Status: Alta Gestão.");
        }
    }
}
