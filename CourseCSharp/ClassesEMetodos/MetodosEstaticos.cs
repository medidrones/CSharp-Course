using System;

namespace CourseCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        // Método de instância!!!
        public int Somar(int a, int b)
        {
            return a + b;
        }

        // Método de Classe ou Método estático!!!
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }
    class MetodosEstaticos
    {
        public static void Executar()
        {
            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2, 2));

            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}", resultado);
                        
        }
    }
}
