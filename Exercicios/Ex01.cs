using System;

namespace Exercicios
{
    class Ex01
    {
        public static void Renderizar()
        {
            //EXERCICIO 1

            Console.Clear();

            Console.WriteLine("---- CALCULANDO ÁREA DE UM RETÂNGULO ----");
            // Imprimir mensagens no terminal
            Console.WriteLine("Informe a altura: ");
            // Conversão de String para um valor inteiro
            int altura = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe a largura: ");
            // Conversão de String para um valor inteiro com Convert
            int largura = Convert.ToInt32(Console.ReadLine());

            int area = altura * largura;

            // Formas de concatenar
            Console.WriteLine($"A área do retângulo é: {area}");
            Console.WriteLine("A área do retângulo é: " + area);
        }
    }
}