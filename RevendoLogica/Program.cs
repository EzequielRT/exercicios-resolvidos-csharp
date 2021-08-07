using System.Globalization;
using System;

namespace RevendoLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio1();
            //Exercicio2();
            //Exercicio3();
            Exercicio4();

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

        /*
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
        */

        /*
        public static void Exercicio3()
        {
            //Com base na tabela de preços, faça um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e
            //mostre o valor da conta a pagar.

            Console.WriteLine("---------------//---------------");
            Console.WriteLine("COD 1 - Cachorro Quente - R$ 4,00");
            Console.WriteLine("COD 2 - X-Salada - R$ 4,50");
            Console.WriteLine("COD 3 - X-Bacon - R$ 5,00");
            Console.WriteLine("COD 4 - Torrada Simples - R$ 2,00");
            Console.WriteLine("COD 5 - Refrigerante - R$ 1,50");
            Console.WriteLine("---------------//---------------");
            Console.Write("Digite o COD do item escolhido: ");
            int cod = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade: ");
            int qtd = int.Parse(Console.ReadLine());

            decimal valor=0, total=0;
            switch (cod)
            {
                case 1:
                    valor = 4.00m;
                    total = valor * qtd;
                    Console.WriteLine("Total: " + total.ToString("C"));
                    break;
                case 2:
                    valor = 4.50m;
                    total = valor * qtd;
                    Console.WriteLine("Total: " + total.ToString("C"));
                    break;
                case 3:
                    valor = 5.00m;
                    total = valor * qtd;
                    Console.WriteLine("Total: " + total.ToString("C"));
                    break;
                case 4:
                    valor = 2.00m;
                    total = valor * qtd;
                    Console.WriteLine("Total: " + total.ToString("C"));
                    break;
                case 5:
                    valor = 1.50m;
                    total = valor * qtd;
                    Console.WriteLine("Total: " + total.ToString("C"));
                    break;
                default:
                    Console.WriteLine("[ERRO] Código inválido!");
                    break;
            }
        }
        */

        public static void Exercicio4()
        {
            //Escreva um programa que repita a leitura de uma senha até que ela seja válida.Para cada leitura de senha
            //incorreta informada, escrever a mensagem "Senha Invalida".Quando a senha for informada corretamente deve ser
            //impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.Considere que a senha correta é o valor 2002.

            int senhaValida = 2002;

            Console.Write("Digite sua senha: ");
            int senhaDigitada = int.Parse(Console.ReadLine());
            while (senhaDigitada != senhaValida) 
            {
                Console.WriteLine("Senha Invalida!");
                Console.Write("Digite sua senha: ");
                senhaDigitada = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido!");
        }
    }
}
