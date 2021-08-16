using System;
using System.Globalization;

namespace EstruturaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //ResolucaoExercicio1();
            //ResolucaoExercicio2();
            ResolucaoExercicio3();
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

        #region Exercicio 3
        //------------------------------------ Exercicio 3 ------------------------------------
        //Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste 
        //de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
        //conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5
        static void ResolucaoExercicio3()
        {
            Console.Write("Digite a qtd de testes que deseja: ");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Digite os 3 valores que deseja saber a média ponderada:");
                string[] valores = Console.ReadLine().Split(" ");
                double n1 = Convert.ToDouble(valores[0], CultureInfo.InvariantCulture);
                double n2 = Convert.ToDouble(valores[1], CultureInfo.InvariantCulture);
                double n3 = Convert.ToDouble(valores[2], CultureInfo.InvariantCulture);

                double mediaPonderada = (n1 * 2.0 + n2 * 3.0 + n3 * 5.0) / 10.0;

                Console.WriteLine(mediaPonderada.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
        #endregion
    }
}
