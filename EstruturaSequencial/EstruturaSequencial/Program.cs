using System;
using System.Globalization;

namespace EstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            //ResolucaoExercicio1();
            //ResolucaoExercicio2();
            //ResolucaoExercicio3();
            ResolucaoExercicio4();
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

        #region Exercicio 3
        //------------------------------------ Exercicio 3 ------------------------------------
        //Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto 
        //de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A* B - C* D).
        static void ResolucaoExercicio3()
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            int D = Convert.ToInt32(Console.ReadLine());
            int DIFERENCA = (A * B - C * D);

            Console.WriteLine($"DIFERENCA = {DIFERENCA}");
        }
        #endregion

        #region Exercicio 4
        //------------------------------------ Exercicio 4 ------------------------------------
        //Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por 
        //hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
        //decimais.
        static void ResolucaoExercicio4()
        {
            int numFuncionario = Convert.ToInt32(Console.ReadLine());
            double horasTrabalhadas = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            decimal valorHora = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);

            decimal salario = (decimal)horasTrabalhadas * valorHora;

            Console.WriteLine($"NUMBER = {numFuncionario}");
            Console.WriteLine($"SALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        #endregion

    }

}