using System;
using System.Collections.Generic;
using System.Text;

namespace Herança
{
    class funcionário
    {
        public string Nome { get; set; }
        public double Horas { get; set; }
        public double ValorHora { get; set; }

        public funcionário(string nome, double horas, double Vhora)
        {
            this.Nome = nome;
            this.Horas = horas;
            this.ValorHora = Vhora;
        }
        public virtual double salario()
        {
            double salario = this.Horas * this.ValorHora;
            return salario;
        }
    }
}
