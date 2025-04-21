using System;
using System.Globalization;

public class Funcionario
{
    public string NomeCompleto { get; set; }
    public double Salario { get; set; }

    public virtual void ExibirDados()
    {
        string[] partesNome = NomeCompleto.Split(' ');
        string ultimoSobrenome = partesNome[partesNome.Length - 1].ToUpper();

        Console.WriteLine($"Sobrenome: {ultimoSobrenome}");
        Console.WriteLine($"Salário: {Salario.ToString("C", new CultureInfo("pt-BR"))}");
    }
}
