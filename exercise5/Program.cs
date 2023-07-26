using System;
using System.Globalization;

namespace exercise5
{
    public class _exercise5
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto 
            //de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).


            Console.WriteLine("Digite um valor: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            int b = int.Parse(Console.ReadLine()) ;
            Console.WriteLine("Digite o terceiro valor: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o último valor:");
            int d = int.Parse(Console.ReadLine());

            int dif1 = (a * b - c * d);

            Console.WriteLine("A diferença é: " + dif1);

        }
    }
}