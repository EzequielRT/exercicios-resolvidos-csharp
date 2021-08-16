using System;

namespace EstruturaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            ResolucaoExercicio1();
        }

        #region Exercicio 1
        //------------------------------------ Exercicio 1 ------------------------------------
        //Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o 
        //X, se for o caso.
        static void ResolucaoExercicio1()
        {
            Console.Write("Digite um número: ");
            int X = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= X; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        #endregion
    }
}
