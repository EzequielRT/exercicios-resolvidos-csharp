using System;

namespace EstruturaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            ResolucaoExercicio1();
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
    }
}
