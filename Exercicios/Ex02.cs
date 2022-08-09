using System;

namespace Exercicios 
{
    class Ex02
    {
        public static void Renderizar()
        {
            //EXERCICIO 2
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Informe um número: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe outro número: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                Console.Write($"{n1} é maior e {n2} é menor");
            } else {
                Console.Write($"{n2} é maior e {n1} é menor");
            }

        }
    }
}