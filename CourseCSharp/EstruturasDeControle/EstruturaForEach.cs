using System;

namespace CourseCSharp.EstruturasDeControle
{
    class EstruturaForEach
    {
        public static void Executar()
        {
            var palavra = "Developer!";

            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);
            }

            Console.WriteLine("===========================");

            var alunos = new string[]
            {
                "Ana", "Bia", "Carlos"
            };

            foreach (string aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
