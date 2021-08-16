using System;

namespace EstruturaFor
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

        #region Exercicio 2
        //------------------------------------ Exercicio 2 ------------------------------------
        //Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
        //Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos estão fora do intervalo, mostrando
        //essas informações conforme exemplo(use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
        static void ResolucaoExercicio2()
        {
            Console.Write("Digite a qtd de numeros que serão digitados: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int count_in = 0, count_out = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.Write("Digite um numero: ");
                int X = Convert.ToInt32(Console.ReadLine());

                if (X >= 10 && X <= 20)
                {
                    count_in++;
                }
                else
                {
                    count_out++;
                }
            }

            Console.WriteLine($"{count_in} in");
            Console.WriteLine($"{count_out} out");
        }
        #endregion
    }
}
