using System;

namespace EstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            ResolucaoExercicio1();
        }


        #region
        //------------------------------------ Exercicio 1 ------------------------------------
        //Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma 
        //mensagem explicativa, conforme exemplos.
        static void ResolucaoExercicio1()
        {
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int soma = n1 + n2;
            Console.WriteLine($"SOMA = {soma}");
        }
        #endregion

    }

}