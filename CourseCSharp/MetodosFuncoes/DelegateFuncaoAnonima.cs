﻿using System;

namespace CourseCSharp.MetodosFuncoes
{
    class DelegateFuncaoAnonima
    {
        delegate string StringOperacao(string s);

        public static void Executar()
        {
            StringOperacao inverter = delegate (string s)
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            };

            Console.WriteLine(inverter("C# é show!!!"));
        }
    }
}
