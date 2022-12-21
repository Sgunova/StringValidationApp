using System;
using System.Collections.Generic;

namespace StringValidationApp
{
    public class Program
    {
        public static bool StringChecking(string inputText)
        {
            var symbols = "[]{}()";
            var Cache = new Stack<char>();

            foreach(char item in inputText){
                if("{([".Contains(item))
                    Cache.Push(item);
                else if ("}])".Contains(item))
                {
                    if (Cache.Count == 0)
                        return false;

                    var lastItem = Cache.Pop();
                    var index = symbols.IndexOf(lastItem);

                    if (symbols[index+1] != item)
                        return false;
                }
            }

            return (Cache.Count == 0) ? true : false;
        }
        public static int Main(string[] args)
        {
            string inputText;
            if (args.Length!=0)
                inputText = args[0];
            else
            {
                Console.WriteLine("Введите строку для анализа расположения ковычек: ");
                inputText = Console.ReadLine();
            }

            var result = StringChecking(inputText);
            Console.WriteLine($"В строке {(result?"не ":string.Empty)}найдены ошибки в расположении и количестве ковычек.");
            
            return result?0:1;
        }
    }
}
