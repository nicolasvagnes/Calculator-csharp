using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();

        }
        static void Menu()   
        {
            Console.Clear();
            Console.WriteLine("O que deseja fazer?");

            Console.WriteLine("1- Soma");
            Console.WriteLine("2- Subtraçao");
            Console.WriteLine("3- Divisao");
            Console.WriteLine("4- Multiplicaçao");
            Console.WriteLine("5- Sair");
            Console.WriteLine("_________________");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Sub(); break;
                case 3: Div(); break;
                case 4: Mult(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;
            Console.WriteLine("O resultado é: " + resultado);
            Console.ReadKey();
            Menu();
        }
        static void Sub()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtraçao é {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Div()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");;
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            
            float resultado = v1 / v2;
            Console.WriteLine($"Resultado da divisao é {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Mult()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado é {resultado}");
            Console.ReadKey();
            Menu();

        }
    }
}
