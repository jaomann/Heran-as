using System;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseja cadastrar quantos funcionários?");
            int colabs = int.Parse(Console.ReadLine());
            Funcionario[] colaboradores = new Funcionario[colabs];
            for (int i = 0; i < colabs; i++)
            {
                Console.WriteLine("O funcionário a ser cadastrado é terceirizado?(1 para sim e 0 para não)");
                double opt = double.Parse(Console.ReadLine());
                string nome;
                double horas;
                double valorHora;
                switch (opt) {
                    case 0:

                            Console.WriteLine("Informe o nome: ");
                            nome = Console.ReadLine();
                            Console.WriteLine("Horas trabalhadas no mês");
                            horas = double.Parse(Console.ReadLine());
                            Console.WriteLine("O valor de hora");
                            valorHora = double.Parse(Console.ReadLine());
                            Funcionario pessoa = new Funcionario(nome, horas, valorHora);
                            colaboradores[i] = pessoa;
                        break;

                    case 1:
                        
                            Console.WriteLine("Informe o nome: ");
                            nome = Console.ReadLine();
                            Console.WriteLine("Horas trabalhadas no mês");
                            horas = double.Parse(Console.ReadLine());
                            Console.WriteLine("O valor de hora");
                            valorHora = double.Parse(Console.ReadLine());
                            pessoa = new FuncionarioTerceirizado(nome, horas, valorHora);
                            colaboradores[i] = pessoa;
                        break;
                }
            }
            for (int i = 0; i < colabs; i++)
            {
                Console.WriteLine($"---------Nome: {colaboradores[i].Nome}\n" +
                    $"Horas trabalhadas: {colaboradores[i].Horas}\n" +
                    $"Valor/Hora: {colaboradores[i].ValorHora}\n" +
                    $"Salário: {colaboradores[i].salario()}" +
                    $"---------\n");

            }
        }
    }
}
