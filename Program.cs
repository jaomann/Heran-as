using System;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            do
            {
                Console.WriteLine("Informe o primeiro e segundo número para a operação");
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Qual operação deseja fazer?\n1-soma.\n2-subtracao.\n3-multiplicacao.\n4-divisao.");
                int op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    Calculadora calc1 = new Calculadora(num1, num2);
                    double result = calc1.Soma(num1, num2);
                    Console.WriteLine($"O resultado é: {result}");
                    Console.WriteLine(":)");
                }
                else if (op == 2)
                {
                    Calculadora calc1 = new Calculadora(num1, num2);
                    double result = calc1.Subtracao(num1, num2);
                    Console.WriteLine($"O resultado é: {result}");
                    Console.WriteLine(":)");
                }
                else if (op == 3)
                {
                    Calculadora calc1 = new Calculadora(num1, num2);
                    double result = calc1.Multiplicacao(num1, num2);
                    Console.WriteLine($"O resultado é: {result}");
                    Console.WriteLine(":)");
                }
                else if (op == 4)
                {
                    Calculadora calc1 = new Calculadora(num1, num2);
                    double result = calc1.Divisao(num1, num2);
                    Console.WriteLine($"O resultado é: {result}");
                    Console.WriteLine(":)");
                }
                else
                {
                    run = false;
                }
            }
            while (run == true);
        }
    }
}
