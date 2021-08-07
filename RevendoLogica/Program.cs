using System.Globalization;
using System;

namespace RevendoLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio1();
            Exercicio2();

        }

        /*
        public static void Exercicio1(){
            //Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
            //código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

            decimal total=0;
            for (int i = 0; i < 2; i++){
                Console.Write("Digite o código da peça: ");
                int cod = int.Parse(Console.ReadLine());
                Console.Write("Digite a quantidade de peças: ");
                int unid = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor unitário da peça: R$ ");
                decimal preco = decimal.Parse(Console.ReadLine());

                decimal calc = unid * preco;
                total += calc;
            }

            Console.Write("VALOR A PAGAR: " + total.ToString("C"));
        }
        */

        public static void Exercicio2()
        {
            //Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
            //casas decimais conforme exemplos.

            double area = 0, raio = 0;
            double PI = Math.PI;
            Console.Write("Digite o valor do raio: ");
            raio = double.Parse(Console.ReadLine());
            area = PI * (raio * raio);
            Console.WriteLine("O valor da área deste círculo é: " + Math.Round(area, 4));
        }
    }
}
