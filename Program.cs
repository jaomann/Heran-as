using System;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseja cadastrar quantos funcionários?");
            int colabs = int.Parse(Console.ReadLine());
            funcionário[] colaboradores = new funcionário[colabs];
            for (int i = 0; i < colabs; i++)
            {
                Console.WriteLine("O funcionário a ser cadastrado é terceirizado?(1 para sim e para não 0)");
                double opt = double.Parse(Console.ReadLine());
                if (opt == 0) 
                {
                    Console.WriteLine("Informe o nome: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Horas trabalhadas no mês");
                    double horas = double.Parse(Console.ReadLine());
                    Console.WriteLine("O valor de hora");
                    double valorHora = double.Parse(Console.ReadLine());
                    funcionário pessoa = new funcionário(nome, horas, valorHora);
                    colaboradores[i] = pessoa; 
                }
                else if (opt == 1)
                {
                    Console.WriteLine("Informe o nome: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Horas trabalhadas no mês");
                    double horas = double.Parse(Console.ReadLine());
                    Console.WriteLine("O valor de hora");
                    double valorHora = double.Parse(Console.ReadLine());
                    funcionário pessoa = new funcionário(nome, horas, valorHora);
                    colaboradores[i] = pessoa;
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
