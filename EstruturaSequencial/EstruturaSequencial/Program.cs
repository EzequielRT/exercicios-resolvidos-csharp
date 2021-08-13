using System;
using System.Collections.Generic;
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
            //ResolucaoExercicio4();
            ResolucaoExercicio5();
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

        #region Exercicio 5
        //------------------------------------ Exercicio 5 ------------------------------------
        //Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
        //código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
        static void ResolucaoExercicio5()
        {
            double total = 0.0;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Digite o código da peça, a qtd de peças e o valor unitário de cada peça (tudo na mesma linha. Ex: 12 1 5.30)");
                string[] valores = Console.ReadLine().Split(" ");
                int codPeca = Convert.ToInt32(valores[0]);
                int qtdPecas = Convert.ToInt32(valores[1]);
                double precoPecas = Convert.ToDouble(valores[2], CultureInfo.InvariantCulture);
                double valor = qtdPecas * precoPecas;
                total += valor;
            }

            Console.WriteLine($"VALOR A PAGAR R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        #endregion

    }

}