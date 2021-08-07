using System.Globalization;
using System;

namespace RevendoLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio1();
            
        }

        
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
    }
}
