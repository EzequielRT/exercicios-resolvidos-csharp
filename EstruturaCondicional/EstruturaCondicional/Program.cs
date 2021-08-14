using System;
using System.Globalization;

namespace EstruturaCondicional
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
        //fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
        static void ResolucaoExercicio1()
        {

            Console.Write("Digite um número para saber se é par ou ímpar: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
        #endregion

        #region Exercicio 2
        //------------------------------------ Exercicio 2 ------------------------------------
        //Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
        static void ResolucaoExercicio2()
        {

            Console.Write("Digite um número para saber se é negativo ou não: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NAO NEGATIVO");
            }
        }
        #endregion

        #region Exercicio 3
        //------------------------------------ Exercicio 3 ------------------------------------
        //Leia 2 valores inteiros(A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao 
        //Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em 
        //ordem crescente ou decrescente.
        static void ResolucaoExercicio3()
        {

            Console.Write("Digite dois valores inteiros para saber se são múltiplos ou não (Ex: 4 2): ");

            string[] numeros = Console.ReadLine().Split(" ");
            int A = Convert.ToInt32(numeros[0]);
            int B = Convert.ToInt32(numeros[1]);

            int soma = A + B;

            if (soma % 2 == 0)
            {
                Console.WriteLine("SAO MULTIPLOS");
            }
            else
            {
                Console.WriteLine("NÃO SAO MULTIPLOS");
            }

            
        }
        #endregion

        #region Exercicio 4
        //------------------------------------ Exercicio 4 ------------------------------------
        //Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode 
        //começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas
        static void ResolucaoExercicio4()
        {
            Console.Write("Digite a hora inicial e final do jogo (Ex: 16 2): ");
            string[] horas = Console.ReadLine().Split(" ");
            int hrInicial = Convert.ToInt32(horas[0]);
            int hrFinal = Convert.ToInt32(horas[1]);

            int duracao = 0;
            if (hrInicial < hrFinal)
            {
                duracao = hrFinal - hrInicial;
            }
            else
            {
                duracao = 24 - hrInicial + hrFinal;
            }

            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");

        }
        #endregion

        #region Exercicio 5
        //------------------------------------ Exercicio 5 ------------------------------------
        //Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A 
        //seguir, calcule e mostre o valor da conta a pagar.
        static void ResolucaoExercicio5()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("COD 1 - Hot-Dog - R$ 4.00");
            Console.WriteLine("COD 2 - X-Salada - R$ 4.50");
            Console.WriteLine("COD 3 - X-Bacon - R$ 5.00");
            Console.WriteLine("COD 4 - Torrada - R$ 2.00");
            Console.WriteLine("COD 5 - Refri - R$ 1.50");
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Digite o cod do produto e a qtd de itens (Ex: 1 3): ");
            string[] produtos = Console.ReadLine().Split(" ");

            int cod = Convert.ToInt16(produtos[0]);
            int qtd = Convert.ToInt16(produtos[1]);
            double preco = 0.0;
            double total = 0.0;

            if (cod == 1)
            {
                preco = 4.00;
                total = preco * qtd;
            }
            else if (cod == 2)
            {
                preco = 4.50;
                total = preco * qtd;
            }
            else if (cod == 3)
            {
                preco = 5.00;
                total = preco * qtd;
            }
            else if (cod == 4)
            {
                preco = 2.00;
                total = preco * qtd;
            }
            else if (cod == 5)
            {
                preco = 1.50;
                total = preco * qtd;
            }
            else
            {
                Console.WriteLine("[ERRO]Código inválido!");
            }

            Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        #endregion
    }
}
