using System;
using System.Globalization;

namespace EstruturaSequencial
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

        #region Exercicio 2
        //------------------------------------ Exercicio 2 ------------------------------------
        //Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
        //casas decimais conforme exemplos.
        //Fórmula da área: area = π . raio*raio
        //Considere o valor de π = 3.14159
        static void ResolucaoExercicio2()
        {
            double raio = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double PI = 3.14159;
            double area = PI * (raio * raio);
            Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
        #endregion

    }

}