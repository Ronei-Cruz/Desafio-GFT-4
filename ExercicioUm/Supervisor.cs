namespace ExercicioUm
{
    public class Supervisor : Colaborador
    {
        public Supervisor(string? nome, int idade, double salario, int grauInstrucao) : base(nome, idade, salario, grauInstrucao)
        {
        }

        public override double Bonificacao()
        {
            double salarioReajuste =  this.Salario + 500 * this.GrauInstrucao;
            return salarioReajuste;
        }
    }
}