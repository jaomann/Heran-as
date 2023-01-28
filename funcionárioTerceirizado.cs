using System;
using System.Collections.Generic;
using System.Text;

namespace Herança
{
    class funcionárioTerceirizado : funcionário
    {
        public double AddDespesa;

        public funcionárioTerceirizado(string nome, double horas, double vhora) : base(nome, horas, vhora)
        {
        }
        public override double salario()
        {
            double salario = this.Horas * this.ValorHora * (AddDespesa * 2.10);
            return salario;
        }
    }
}
