using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    internal class Utils
    {
        // Frågar användaren efter sträng inmatning
        public static string GetStringInput(string prompt)
        {
            Console.WriteLine("\n" + prompt);
            var input = Console.ReadLine();
            // Frågar användaren efter korrekt inmatning ifall input skulle vara null för någon anledning
            while (input is null)
            {
                Console.WriteLine("Ogiltig inmatning. Försök igen\n");
                Console.WriteLine(prompt);
                input = Console.ReadLine();
            }

            return input;
        }
        // Frågar användaren efter sträng inmatning inom det efterfrågade ordspannet
        public static string GetStringInput(string prompt, int minWords = 1, int maxWords = int.MaxValue)
        {
            Console.WriteLine("\n" + prompt);
            var input = Console.ReadLine();
            // Frågar användaren efter korrekt inmatning ifall input skulle vara null för någon anledning
            // eller ej inom ordspannet
            while (input is null || GetWordCount(input) < minWords || GetWordCount(input) > maxWords)
            {
                Console.WriteLine("Ogiltig inmatning. Försök igen\n");
                Console.WriteLine(prompt);
                input = Console.ReadLine();
            }

            return input;
        }
        // Frågar användaren efter numerisk inmatning
        public static int GetIntInput(string prompt)
        {
            Console.WriteLine("\n" + prompt);
            var input = Console.ReadLine();
            int number;
            // Frågar användaren efter korrekt inmatning ifall input inte är integer
            while (!int.TryParse(input, out number))
            {
                Console.WriteLine("Ogiltig inmatning. Försök igen\n");
                Console.WriteLine(prompt);
                input = Console.ReadLine();
            }

            return number;
        }
        // Frågar användaren efter numerisk inmatning inom det efterfrågade spannet
        public static int GetIntInput(string prompt, int min = int.MinValue, int max = int.MinValue)
        {
            Console.WriteLine("\n" + prompt);
            var input = Console.ReadLine();
            int number;
            // Frågar användaren efter korrekt inmatning ifall input inte är integer eller ej inom spannet
            while (!int.TryParse(input, out number) || number < min || number > max)
            {
                Console.WriteLine("Ogiltig inmatning. Försök igen\n");
                Console.WriteLine(prompt);
                input = Console.ReadLine();
            }

            return number;
        }

        public static int GetWordCount(string input)
        {
            string[] words = input.Split(" ");
            return words.Length;
        }
    }
}
