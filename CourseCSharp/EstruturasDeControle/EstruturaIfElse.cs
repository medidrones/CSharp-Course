using System;

namespace CourseCSharp.EstruturasDeControle
{
    class EstruturaIfElse
    {
        public static void Executar()
        {
            double nota = 7.0;

            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Parabéns pela dedicação e empenho...");
            }
            else
            {
                Console.WriteLine("Recuperação");
            }
        }
    }
}
