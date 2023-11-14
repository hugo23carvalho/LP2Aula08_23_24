using System;

namespace ExtendString
{
    class Program
    {
        static void Main()
        {
            string str = "Uma string bem fixe!";

            string strMod1 = str.ToRandomCase1();
            string strMod2 = str.ToRandomCase2();
            string strMod3 = str.ToRandomCase3();

            Console.WriteLine($"Original                       : {str}");
            Console.WriteLine($"Criada através de concatenação : {strMod1}");
            Console.WriteLine($"Criada com StringBuilder       : {strMod2}");
            Console.WriteLine($"Criada com StringWriter        : {strMod3}");
        }
    }
}
