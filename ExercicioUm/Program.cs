using System;

namespace ExercicioUm
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerente = new Gerente("Jose", 55, 5000, 2);
            Console.WriteLine($"Gerente recebe: R$ {gerente.Bonificacao()}");

            Supervisor supervisor = new Supervisor("João", 42, 3000, 3);
            Console.WriteLine($"Supervisor recebe: R$ {supervisor.Bonificacao()}");

            Vendedor vendedor = new Vendedor("Mario", 22, 1200, 4);
            Console.WriteLine($"Vendedor recebe: R$ {vendedor.Bonificacao()}");
        }
    }
}

