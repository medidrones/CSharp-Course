using System;

namespace CourseCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;

            Console.WriteLine("O " + nome + " da marca " + marca + " custa " + preco + ".");
            Console.WriteLine("O {0} da marca {1} custa {2}.", nome, marca, preco);
            Console.WriteLine($"A marca {marca} é legal!");
            Console.WriteLine($"5 + 6 = {5 + 6}");
            Console.WriteLine($"10 - 6 = {10 - 6}");
            Console.WriteLine($"5 * 6 = {5 * 6}");
            Console.WriteLine($"10 / 2 = {10 / 2}");
            Console.WriteLine($"12 % 5 = {12 % 5}");
        }
    }
}
