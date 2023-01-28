namespace Herança
{
    class FuncionarioTerceirizado : Funcionario
    {
        public FuncionarioTerceirizado(string nome, double horas, double vhora) : base(nome, horas, vhora)
        {
        }
        public override double salario()
        {
            double salario;
            salario = (this.Horas * this.ValorHora) * 1.10;
            return salario;
        }
    }
}
