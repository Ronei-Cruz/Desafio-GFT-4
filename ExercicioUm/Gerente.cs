namespace ExercicioUm
{
    public class Gerente : Colaborador
    {
        public Gerente(string? nome, int idade, double salario, int grauInstrucao) : base(nome, idade, salario, grauInstrucao)
        {
        }

        public override double Bonificacao()
        {
            double salarioReajuste =  this.Salario + 1000 * this.GrauInstrucao;
            return salarioReajuste;
        }
    }
}