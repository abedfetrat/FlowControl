using System.Diagnostics.Tracing;

namespace FlowControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                PrintMenu();

                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CheckCinemaTicketPrice();
                        break;
                    case "2":
                        RepeatTenTimes();
                        break;
                    case "3":
                        PrintThirdWord();
                        break;
                    case "q":
                    case "Q":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Ogiltig inmatning. Försök igen\n");
                        break;
                }

            }
        }

        // Skriver ut menyn
        private static void PrintMenu()
        {
            Console.WriteLine("\n---------------------------- MENY ----------------------------\n");
            Console.WriteLine("1. Bio priser");
            Console.WriteLine("2. Repetera 10 gånger");
            Console.WriteLine("3. Skriv ut tredje ordet");
            Console.WriteLine("Q. Avsluta programet");
            Console.WriteLine("\nVad vill du göra? Mata in ditt val: ");
        }
        // Frågar användaren om ålder och antal sällskap och skriver ut bio priser
        private static void CheckCinemaTicketPrice()
        {
            int numPersons = Utils.GetIntInput("Hur många personer? (1-300)", 1, 300);

            if (numPersons > 1)
            {
                CinemaHelpers.CheckTicketPriceForMultiplePersons(numPersons);
            }
            else
            {
                CinemaHelpers.CheckTicketPriceForSinglePerson();
            }
        }
        // Frågar användaren efter inmatning och skriver ut det tio gånger
        private static void RepeatTenTimes()
        {
            string input = Utils.GetStringInput("Vad vill du repetera? Mata in det: ");
            string output = "";

            for (int i = 1; i <= 10; i++)
            {
                output += $"{i}.{input} ";
            }

            Console.WriteLine(output);
        }
        // Frågar användaren efter inmatning och skriver ut det tredje ordet
        private static void PrintThirdWord()
        {
            string input = Utils.GetStringInput("Mata in en mening med minst tre ord: ", 3);
            
            string[] words = input.Split(" ");
            List<string> output = [];
            // Iterera över arrayen med ord och ta bort alla mellanslag
            foreach(string word in words)
            {
                if (!String.IsNullOrWhiteSpace(word))
                {
                    output.Add(word);
                }
            }

            Console.WriteLine($"Tredje ordet: {output[2]}");
        }
    }
}
