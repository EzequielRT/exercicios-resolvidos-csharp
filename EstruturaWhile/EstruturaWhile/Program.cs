using System;

namespace EstruturaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //ResolucaoExercicio1();
            //ResolucaoExercicio2();
            ResolucaoExercicio3();
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

        #region Exercicio 3
        //------------------------------------ Exercicio 3 ------------------------------------
        //Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva 
        //um algoritmo para ler o tipo de combustível abastecido(codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
        //4.Fim). Caso o usuário informe um código inválido(fora da faixa de 1 a 4) deve ser solicitado um novo código(até
        //que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
        //mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme exemplo.

        static void ResolucaoExercicio3()
        {
            Console.WriteLine("_______________________________________________");
            Console.WriteLine("Digite um dos códigos conforme tabela abaixo:");
            Console.WriteLine("1.Álcool");
            Console.WriteLine("2.Gasolina");
            Console.WriteLine("3.Diesel");
            Console.WriteLine("4.Fim");
            Console.Write("Opcao: ");
            int cod = Convert.ToInt32(Console.ReadLine());

            int alcool=0, gasolina=0, diesel=0;

            while (cod != 4)
            {
                if (cod == 1)
                {
                    alcool++;
                }
                else if (cod == 2)
                {
                    gasolina++;
                }
                else if (cod == 3)
                {
                    diesel++;
                }
                else
                {
                    Console.WriteLine("[ERRO]Digite um código válido!");
                }

                Console.WriteLine("_______________________________________________");
                Console.WriteLine("Digite um dos códigos conforme tabela abaixo:");
                Console.WriteLine("1.Álcool");
                Console.WriteLine("2.Gasolina");
                Console.WriteLine("3.Diesel");
                Console.WriteLine("4.Fim");
                Console.Write("Opcao: ");
                cod = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
        #endregion
    }
}
