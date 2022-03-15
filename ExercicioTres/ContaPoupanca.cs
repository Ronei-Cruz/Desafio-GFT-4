namespace ExercicioTres
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(int numero, string titular, double saldo) : base(numero, titular, saldo)
        {
        }

        public override double Rendimento()
        {
            double saldoAtual = this.Saldo + (this.Saldo * 0.07);
            return saldoAtual;
        }
    }
}