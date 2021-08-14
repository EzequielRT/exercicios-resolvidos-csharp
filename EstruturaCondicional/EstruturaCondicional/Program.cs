using System;

namespace EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            ResolucaoExercicio1();
        }

        #region Exercicio 1
        //------------------------------------ Exercicio 1 ------------------------------------
        //fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
        static void ResolucaoExercicio1()
        {

            Console.Write("Digite um número para saber se é par ou ímpar: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
        #endregion
    }
}
