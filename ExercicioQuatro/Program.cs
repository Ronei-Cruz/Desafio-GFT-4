using System;

namespace ExercicioQuatro
{
    class Program
    {
        static void Main(string[] args)
        {
            float peso = 0;
            float altura = 0;

            Console.WriteLine("Digite seu peso: ");
            peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua altura: ");
            altura = float.Parse(Console.ReadLine());

            float resultado = IndiceMC(peso, altura);
            Console.WriteLine(resultado);
            if(resultado < 18.5)
            {
                Console.WriteLine("Abaixo do Peso");
            }
            else if((resultado <= 18.5) || (resultado < 24.9))
            {
                Console.WriteLine("Peso Normal");
            }
            else if((resultado <= 25) || (resultado < 29.9))
            {
                Console.WriteLine("Sobrepeso");
            }
            else if((resultado <= 30) || (resultado < 34.9))
            {
                Console.WriteLine("Obesidade Grau 1");
            }
            else if((resultado <= 35) || (resultado < 39.9))
            {
                Console.WriteLine("Obesidade Grau 2");
            }
            else if(resultado > 40)
            {
                Console.WriteLine("Obesidade Grau 3");
            }

        }

        private static float IndiceMC(float peso, float altura)
        {
            float imc = (peso /(altura * altura));
            return imc;
        }
    }
}