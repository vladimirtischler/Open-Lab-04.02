using System;

namespace Open_Lab_04._02
{
    class Program
    {
        public static string DoubleChar(string original)
        {
            string a = "";
            for (int w = 0;w < original.Length;w++)
            {
                for (int c = 0;c < 2;c++)
                {
                    a = a + original[w];
                }
            }
            return a;
        }
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(DoubleChar(word));
        }
    }
}
