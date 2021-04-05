using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Write any word:");
			string sc = Console.ReadLine();
			Console.Write("Matches with last letter -->  ");
			char ch = sc[sc.Length - 1];
			bool flag = true;
			for (int i = 0; i < sc.Length - 1; i++)
			{
				if (ch == sc[i])
				{
					Console.Write(i + 1 + " ");
					flag = false;
			
				}
			}
			if (flag)
			{
				Console.WriteLine("No matches");
			}
			Console.ReadKey();
		}
	}
}
