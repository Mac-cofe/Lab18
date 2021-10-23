using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = "{1[2]3(4)}";
            Obrabotka(input1);
            Console.WriteLine("-------------------------------------");
            string input2 = "[123{23[4]45561}";
            Obrabotka(input2);
            Console.WriteLine("-------------------------------------");
            string input3 = "Объект{человек} имя [Иван](информация)";
            Obrabotka(input3);
            Console.WriteLine("-------------------------------------");
            string input4 = "2+2=[2+(4-2)+0={}";
            Obrabotka(input4);

            Console.ReadKey();
        }

            public static void Obrabotka(string input)
            {
            Stack<char> brackets = new Stack<char>();
            Console.WriteLine($"Исходная строка = {input}");
            Console.WriteLine();
                char[] text = new char[input.Length];   
            for (int i = 0; i < input.Length; i++)
            {
                text[i] = input[i];
                if (text[i] == '(')
                { brackets.Push(')'); }
                if (text[i] == '{')
                { brackets.Push('}'); }
                if (text[i] == '[')
                { brackets.Push(']'); }
                    if (text[i] == '}' && brackets.Peek() == '}')
                        brackets.Pop();
                    if (text[i] == ')' && brackets.Peek() == ')')
                        brackets.Pop();
                    if (text[i] == ']' && brackets.Peek() == ']')
                        brackets.Pop();
            }
            if (brackets.Count != 0)
            {
                Console.WriteLine("Скобки расставлены некорректно. В стеке остались такие элементы:");
                foreach (char s in brackets)
                {
                    Console.WriteLine(s);
                }
            }
            else
                Console.WriteLine("Скобки расставлены верно. Cтек пуст");
        }
    }
}
