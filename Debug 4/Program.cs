using System;

namespace Debug_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] digit = new int[2];
            int index = 0;

            Console.WriteLine("Hello World!");
            Console.Write("Input two integers, separated by a comma:");
            string inputString = Console.ReadLine();
            string[] InputToken = inputString.Split(',');
            foreach (string token in InputToken)
            {
                digit[index] = Int32.Parse(token);
            }
            Console.WriteLine("{0}+{1}={2}", digit[0], digit[1], digit[0] + digit[1]);
            Console.WriteLine("{0}-{1}={2}", digit[0], digit[1], digit[0] - digit[1]);
            Console.WriteLine("{0}*{1}={2}", digit[0], digit[1], digit[0] * digit[1]);
            Console.WriteLine("{0}/{1}={2}", digit[0], digit[1], digit[0] / digit[1]);
        }
    }
}
