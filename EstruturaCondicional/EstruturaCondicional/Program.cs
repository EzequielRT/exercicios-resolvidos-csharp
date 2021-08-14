using System;

namespace EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            //ResolucaoExercicio1();
            ResolucaoExercicio2();
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

        #region Exercicio 2
        //------------------------------------ Exercicio 2 ------------------------------------
        //Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
        static void ResolucaoExercicio2()
        {

            Console.Write("Digite um número para saber se é negativo ou não: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NAO NEGATIVO");
            }
        }
        #endregion
    }
}
