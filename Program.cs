using System;

namespace Quiz___2_Versão
{
    class Program
    {
        // Perguntas Cadastradas
         public static string Pergunta1 = "Qual a cor presente no círculo da bandeira do Japão";
         public static string Pergunta2 = "Em que cor esta escrito a frase 'Ordem e progresso' na bandeira do Brasil ";
         public static string Pergunta3 = "Qual o único país do mundo cuja bandeira não é retangular";
         public static string Pergunta4 = "Qual a cor do losango presente na bandeira do Brasil";
         public static string Pergunta5 = "Qual a cor presente no círculo da bandeira do Brasil";

        //Respostas Cadastradas
         public static string Resposta1 = "vermelho";
         public static string Resposta2 = "verde";
         public static string Resposta3 = "nepal";
         public static string Resposta4 = "amarelo";
         public static string Resposta5 = "azul";

        //Contador de Acertos
        public static sbyte Acertos = 0;

        //Contador de Erros
        public static sbyte Erros = 0;

        static void Main(string[] args)
        {
            Quiz();
            Resultado();
            Console.Clear();
            Console.WriteLine("Obrigado por jogar!");
        }


        public static void Resultado()
        {
            //Mostra a quantidade de acertos do jogador
            if (Acertos == 0)
            {
                Console.WriteLine("Você não acertou nenhuma resposta");
            }
            else if (Acertos == 1)
            {
                Console.WriteLine($"Você acertou {Acertos} resposta");
            }
            else
            {
                Console.WriteLine($"Você acertou {Acertos} respostas");
            }

            //Mostra a quantidade de erros do jogador
            if (Erros == 0)
            {
                Console.WriteLine("Você não errou nenhuma resposta");
            }
            else if (Erros == 1)
            {
                Console.WriteLine($"Você errou {Erros} resposta");
            }
            else
            {
                Console.WriteLine($"Você errou {Erros} respostas");
            }

            Console.WriteLine("Precione a tecla ENTER para deixar de exibir o resultado");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

        }


        public static void Quiz()
        {
            // Pergunta 1
            Console.WriteLine(Pergunta1);
            Console.Write("Resposta : ");


            if (Console.ReadLine().ToLower().Trim() == Resposta1)
            {
                Console.Clear();
                Console.WriteLine("Resposta Correta\n");
                Acertos++;
                Console.WriteLine("Precione a tecla ENTER para responder a próxima pergunta");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Resposta Incorreta\n");
                Erros++;
                Console.WriteLine("Precione a tecla ENTER para responder a próxima pergunta");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                Console.Clear();
            }


            // Pergunta 2
            Console.WriteLine(Pergunta2);
            Console.Write("Resposta : ");


            if (Console.ReadLine().ToLower().Trim() == Resposta2)
            {
                Console.Clear();
                Console.WriteLine("Resposta Correta\n");
                Acertos++;
                Console.WriteLine("Precione a tecla ENTER para responder a próxima pergunta");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Resposta Incorreta\n");
                Erros++;
                Console.WriteLine("Precione a tecla ENTER para responder a próxima pergunta");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                Console.Clear();
            }

            // Pergunta 3
            Console.WriteLine(Pergunta3);
            Console.Write("Resposta : ");


            if (Console.ReadLine().ToLower().Trim() == Resposta3)
            {
                Console.Clear();
                Console.WriteLine("Resposta Correta\n");
                Acertos++;
                Console.WriteLine("Precione a tecla ENTER para responder a próxima pergunta");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Resposta Incorreta\n");
                Erros++;
                Console.WriteLine("Precione a tecla ENTER para responder a próxima pergunta");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                Console.Clear();
            }

            // Pergunta 4
            Console.WriteLine(Pergunta4);
            Console.Write("Resposta : ");


            if (Console.ReadLine().ToLower().Trim() == Resposta4)
            {
                Console.Clear();
                Console.WriteLine("Resposta Correta\n");
                Acertos++;
                Console.WriteLine("Precione a tecla ENTER para responder a próxima pergunta");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Resposta Incorreta\n");
                Erros++;
                Console.WriteLine("Precione a tecla ENTER para responder a próxima pergunta");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                Console.Clear();
            }

            // Pergunta 5
            Console.WriteLine(Pergunta5);
            Console.Write("Resposta : ");


            if (Console.ReadLine().ToLower().Trim() == Resposta5)
            {
                Console.Clear();
                Console.WriteLine("Resposta Correta\n");
                Acertos++;
                Console.WriteLine("Precione a tecla ENTER para visualizar o resultado");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Resposta Incorreta\n");
                Erros++;
                Console.WriteLine("Precione a tecla ENTER para visualizar o resultado");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                Console.Clear();
            }
        }
    }
}
