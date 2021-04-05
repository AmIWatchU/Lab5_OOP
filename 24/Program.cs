using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24
{
    class Program
    {
        //24. Дано текст. Знайдіть найбільшу кількість поспіль прогалин в ньому.
        static void Main(string[] args)
        {
            
            Console.Write("Write your text:");
            string s = Console.ReadLine();
            int a = 0;
            int c = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1] && s[i - 1] == ' ')
                    a++;
                else if (c < a + 1)
                {
                    c = a + 1;
                    a = 0;
                }
                else
                    a = 0;
            }
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
