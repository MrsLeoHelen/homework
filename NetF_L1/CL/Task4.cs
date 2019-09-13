using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL
{
    public static class Task4
    {
        public static void DoIt()
        {
            string str;
            Console.WriteLine("Enter your string:");
            str = Console.ReadLine();
            string[] strA = str.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries); //Split разбивает строку на слова используя разделитель 
                                                                                                  // Второй параметр StringSplitOptions.RemoveEmptyEntries говорит, что надо удалить все пустые подстроки.
            Console.WriteLine($"Words in this string = {strA.Length}");
        }
    }
}
