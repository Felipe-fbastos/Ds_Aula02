// See https://aka.ms/new-console-template for more information

using System;
using AULA02RH.Models;
using AULA02RH.Models.Enuns;

namespace AULA02RH // Note: actual namespace depends on the project name.
{
  public class Program
  {
    static void Main(string[] args)
    {

      Funcionario func = new Funcionario();
      /*
        func.Id = 10;
        func.Nome = "Felipe";
        func.Cpf = "12345678910";
        func.DataAdmissao = DateTime.Parse("01/01/2000");
        func.Salario = 10000.00M;
        func.TipoFuncionario = TipoFuncionarioEnum.CLT;

        string mensagem = func.ExibirPeriodoExperiencia();
        Console.WriteLine("===============================");
        Console.WriteLine(mensagem);
        Console.WriteLine("===============================");
        */

        Console.WriteLine("Digite o Id do funcionário: ");
        func.Id = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o nome do funcionário: ");
        func.Nome = Console.ReadLine();

        Console.WriteLine("Digite o CPF: ");
        func.Cpf = Console.ReadLine();

        Console.WriteLine("Digite a data de Admissão: ");
        func.DataAdmissao =  DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Digite o Salário: ");
        func.Salario = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Escolha o tipo de Funcionário");
        int opcao = int.Parse(Console.ReadLine());

        func.TipoFuncionario = (opcao ==1) ? TipoFuncionarioEnum.CLT : TipoFuncionarioEnum.Aprendiz;

        func.ReajustarSalario();
        decimal valorDescontoVT = func.CalcularDescontoVT(6);

        Console.WriteLine("-------------------------");
        Console.WriteLine($"O ID digitado: {func.Id}");
        Console.WriteLine($"O funcionario adicionado foi: {func.Nome}");
        Console.WriteLine($"O CPF adicionado foi: {func.Cpf}");
        Console.WriteLine($"Data de Admissão adionada {func.DataAdmissao}");
        Console.WriteLine($"O salario adicionado foi de: {func.Salario}");
        Console.WriteLine($"O salario com valor descontado ficou com: {valorDescontoVT}");
        Console.WriteLine($"O tipo de funcinário adiconado foi: {func.TipoFuncionario}");




    }


  }
}