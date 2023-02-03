using System;
namespace Herança
{
    public class CalcCientifica : Calculadora
    {
        double raiz;
        public CalcCientifica(double num1, double num2, double raiz) : base (num1, num2)
        {
        }

        public override double Soma(double num1, double num2) => num1 + num2;
        public override double Multiplicacao(double num1, double num2) => num1 * num2;
        public override double Subtracao(double num1, double num2) => num1 - num2;
        public override double Divisao(double num1, double num2) => num1 / num2;
        public double ExtracaoRaiz(double raiz) => Math.Sqrt(raiz);
    }
}
