namespace Herança
{
    public class Calculadora
    {
        double num1;
        double num2;
        public Calculadora(double num1, double num2)
        {
        }
        public virtual double Soma(double num1, double num2) => num1 + num2;
        public virtual double Subtracao(double num1, double num2) => num1 - num2;
        public virtual double Multiplicacao(double num1, double num2) => num1 * num2;
        public virtual double Divisao(double num1, double num2) => num1 / num2;
    }
}
