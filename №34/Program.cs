using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34
{
    // 34.  Вивести слова, в яких замінити кожну велику букву одно-
    //іменниймалої; очистити дисплей повністю, не є буквами або цифрами;
    //вивести в алфавітному порядку всі голосні літери, що входять в кожне слово рядка.
    // 34. Вывести слова, в которых заменить каждую большую букву одноименной малой;
    // удалить все символы, не являющиеся буквами или цифрами;
    // вывести в алфавитном порядке все гласные буквы, входящие в каждое слово строки

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write any text:");
            string txt = Console.ReadLine();
            string newtxt = " ";

            // Заміна усіх великих букв на однойменномалі
            for (int i = 0; i < txt.Length; i++)
                newtxt += txt.ToLower()[i];
            Console.WriteLine("Your text with small letters: ");
            Console.WriteLine(newtxt);

            // Вивід тільки цифр і букв
            Console.WriteLine("Your text without other symbols: s");
            string result1 = new string(newtxt.Where(char.IsLetterOrDigit).ToArray());
            Console.WriteLine(result1);


            // Вивід тільки цифр
            string result = new string(newtxt.Where(char.IsDigit).ToArray());
            Console.WriteLine("Your text but only numbers: ");
            Console.WriteLine(result);

            // Літери, які були застосовані, в алфавітному порядку
            // Enghlish vowels alphabetical oreder: a, e,i, o, u.
            Console.WriteLine("Letter in alphabetical order: ");

            char[] ntxt =  newtxt.Where(char.IsLetter).ToArray() ;
            char[] ntxt2 = ntxt.Distinct().ToArray();
            List<char> listxt = new List<char>();

            for (int i = 0; i < ntxt2.Length; i++)
            {
                if (ntxt2[i] == 'a' || ntxt2[i] == 'e' || ntxt2[i] == 'i'
                    || ntxt2[i] == 'o' || ntxt2[i] == 'u')
                {
                    listxt.Add(ntxt2[i]); 
                } 
            }

            listxt.Sort();
            string result2 = new string(listxt.ToArray());

            Console.WriteLine(result2);

            Console.ReadKey();
        }
    }
}
