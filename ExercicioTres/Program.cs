using System;

namespace ExercicioTres
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente(1,"Jose", 2000);
            Console.WriteLine($"Conta Corrente: {contaCorrente.Rendimento()}");

            ContaPoupanca contaPoupanca = new ContaPoupanca(2,"Joao", 1000);
            Console.WriteLine($"Conta Poupança: {contaPoupanca.Rendimento()}");
        }
    }
}