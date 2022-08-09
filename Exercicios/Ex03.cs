using System;

namespace Exercicios 
{
    class Ex03 
    {
        public static void Renderizar()
        {
            // EXERCICIO 3
            
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Informe sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade <= 13)
            {
                Console.WriteLine("Você é uma criança !!");
            } else if (idade <= 18)
            {
                Console.WriteLine("Você é um adolescente !!");
            } else if (idade <= 60)
            {
                Console.WriteLine("Você é adulto !!");
            } else {
                Console.WriteLine("Você ta véio !!");
            }
        }
    }
}