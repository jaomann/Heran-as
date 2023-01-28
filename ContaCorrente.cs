using System;

namespace Herança
{
    internal class ContaCorrente : ContaPadrão
    {
        public double Limite;
        public double Juros;

        public void ChequeEspecial(double valor)
        {
            if (Limite < valor)
            {
                Console.WriteLine("Não há saldo");
            }
            else
            {
                Limite -= valor;
                this.Juros = valor * 0.01;
            }
        }
    }
}
