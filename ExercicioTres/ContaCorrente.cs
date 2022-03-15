namespace ExercicioTres
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(int numero, string titular, double saldo) : base(numero, titular, saldo)
        {
        }

        public override double Rendimento()
        {
            double saldoAtual = this.Saldo + (this.Saldo * 0.05);
            return saldoAtual - 0.75;
        }
    }
}