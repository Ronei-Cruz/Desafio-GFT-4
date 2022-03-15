namespace ExercicioUm
{
    public class Colaborador
    {
        public string? Nome;
        public int Idade;
        public double Salario;
        public int GrauInstrucao;

        public Colaborador(string? nome, int idade, double salario, int grauInstrucao)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Salario = salario;
            this.GrauInstrucao = grauInstrucao;
        }

        public virtual double Bonificacao()
        {
            double salario = this.Salario;
            return salario;
        }
    }


}