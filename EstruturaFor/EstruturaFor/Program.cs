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
            //ResolucaoExercicio3();
            //ResolucaoExercicio4();
            //ResolucaoExercicio5();
            //ResolucaoExercicio6();
            ResolucaoExercicio7();
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
            Console.Write("Digite a qtd de vzs que sera repetido:: ");
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

        #region Exercicio 4
        //------------------------------------ Exercicio 4 ------------------------------------
        //Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo 
        //segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
        static void ResolucaoExercicio4()
        {
            Console.Write("Digite a qtd de vzs que sera repetido: ");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Digite os 2 valores que deseja saber a divisão:");
                string[] valores = Console.ReadLine().Split(" ");
                double n1 = Convert.ToDouble(valores[0], CultureInfo.InvariantCulture);
                double n2 = Convert.ToDouble(valores[1], CultureInfo.InvariantCulture);

                if (n2 == 0)
                {
                    Console.WriteLine("Divisao impossivel");
                }
                else
                {
                    double divisao = n1 / n2;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }

            }
        }
        #endregion

        #region Exercicio 5
        //------------------------------------ Exercicio 5 ------------------------------------
        //Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
        //Lembrando que, por definição, fatorial de 0 é 1.
        static void ResolucaoExercicio5()
        {
            Console.Write("Digite o numero que deseja saber o fatorial: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int fatorial = 0;
            if (N == 0)
            {
                fatorial = 1;
            }
            else
            {
                fatorial = 1;
                for (int i = 1; i <= N; i++)
                {
                    fatorial = fatorial * i;
                }
            }

            Console.WriteLine(fatorial);
        }
        #endregion

        #region Exercicio 6
        //------------------------------------ Exercicio 6 ------------------------------------
        //Ler um número inteiro N e calcular todos os seus divisores.
        static void ResolucaoExercicio6()
        {
            Console.Write("Digite o numero que deseja saber os seus divisores: ");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        #endregion

        #region Exercicio 7
        //------------------------------------ Exercicio 7 ------------------------------------
        //Fazer um programa para ler um número inteiro positivo N.O programa deve então mostrar na tela N linhas,
        //começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
        //exemplo.
        static void ResolucaoExercicio7()
        {
            Console.Write("Digite um numero: ");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                int quadrado = (int)Math.Pow(i, 2);
                int cubo = (int)Math.Pow(i, 3);

                Console.WriteLine($"{i} {quadrado} {cubo}");
            }
        }
        #endregion
    }
}
