using System;

namespace EstruturaWhile
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
        //Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha 
        //incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
        //impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.Considere que a senha correta é o valor 2002.

        static void ResolucaoExercicio1()
        {
            Console.Write("Digite sua senha: ");
            int senha = Convert.ToInt32(Console.ReadLine());

            while (senha != 2002)
            {                
                Console.WriteLine("Senha Invalida");
                Console.Write("Digite sua senha: ");
                senha = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
        #endregion

        #region Exercicio 2
        //------------------------------------ Exercicio 2 ------------------------------------
       //Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema 
       //cartesiano.Para cada ponto escrever o quadrante a que ele pertence.O algoritmo será encerrado quando pelo
       //menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).

        static void ResolucaoExercicio2()
        {
            Console.Write("Digite as coordenadas X e Y de pontos do sistema cartesiano (Ex: 2 2): ");
            string[] pontos = Console.ReadLine().Split(" ");
            int X = Convert.ToInt32(pontos[0]);
            int Y = Convert.ToInt32(pontos[1]);

            while (X != 0 && Y != 0)
            {
                if (X > 0 && Y > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if (X < 0 && Y > 0)
                {
                    Console.WriteLine("Segundo");
                }
                else if (X < 0 && Y < 0)
                {
                    Console.WriteLine("Terceiro");
                }
                else
                {
                    Console.WriteLine("Quarto");
                }

                Console.Write("Digite as coordenadas X e Y de pontos do sistema cartesiano (Ex: 2 2): ");
                pontos = Console.ReadLine().Split(" ");
                X = Convert.ToInt32(pontos[0]);
                Y = Convert.ToInt32(pontos[1]);
            }
        }
        #endregion
    }
}
