namespace ExercicioUm
{
    public class Vendedor : Colaborador
    {
        public Vendedor(string? nome, int idade, double salario, int grauInstrucao) : base(nome, idade, salario, grauInstrucao)
        {
        }

        public override double Bonificacao()
        {
            double salarioReajuste =  this.Salario + 300 * this.GrauInstrucao;
            return salarioReajuste;
        }
    }
}