namespace ExercicioTres
{
    public class Conta
    {
        public Conta(int numero, string titular, double saldo)
        {
            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = saldo;
        }

        public int Numero {get; set;}
        public string? Titular {get; set;}
        public double Saldo {get; set;}

        public virtual double Rendimento()
        {
            double saldoAtual = this.Saldo;
            return saldoAtual;
        }
    }
}