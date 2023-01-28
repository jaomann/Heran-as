using System;

namespace Herança
{
    class ContaPadrão
    {
        public int Numero;
        public string Nome;
        public double Saldo;

        public void Saque(double valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo Insuficiente");

            }
            else
            {
                Saldo = Saldo - valor;
            }
        }
        public void Depósito(double valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("Impossível depositar valores negativos");
            }
            else
            {
                Saldo += valor;
            }
        }
    }
}
