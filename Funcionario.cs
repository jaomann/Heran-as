namespace Herança
{
    class Funcionario
    {
        public string Nome { get; set; }
        public double Horas { get; set; }
        public double ValorHora { get; set; }

        public Funcionario(string nome, double horas, double Vhora)
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
