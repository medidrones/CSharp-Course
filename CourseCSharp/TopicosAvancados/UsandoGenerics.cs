using System;
using CourseCSharp.ClassesEMetodos;

namespace CourseCSharp.TopicosAvancados
{
    public class Caixa<T>
    {
        T valorPrivado;
        public T Coisa { get; set; }

        public Caixa(T coisa)
        {
            Coisa = coisa;
            valorPrivado = coisa;
        }

        public T metodoGenerico(T valor)
        {
            return new Random().Next(0, 2) == 0 ? Coisa : valor;
        }

        public T GetValor()
        {
            return valorPrivado;
        }
    }

    class CaixaInt : Caixa<int>
    {
        public CaixaInt() : base(0)
        {
        }
    }

    class CaixaProduto : Caixa<Produto>
    {
        public CaixaProduto() : base(new Produto())
        {
        }
    }

    class UsandoGenerics
    {
        public static void Executar()
        {
            var caxa1 = new Caixa<int>(1000);
            Console.WriteLine(caxa1.metodoGenerico(33));
            Console.WriteLine(caxa1.Coisa.GetType());

            var caixa2 = new Caixa<string>("Construtor");
            Console.WriteLine(caixa2.metodoGenerico("Método"));
            Console.WriteLine(caixa2.Coisa.GetType());

            CaixaProduto caixa3 = new CaixaProduto();
            Console.WriteLine(caixa3.Coisa.GetType().Name);
        }
    }
}
