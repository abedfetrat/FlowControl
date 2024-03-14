using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    // Olika metoder för att hjälpa till med funktionalitet till meny val 1
    internal class CinemaHelpers
    {
        public static void CheckTicketPriceForSinglePerson()
        {
            int age = Utils.GetIntInput("Ange ålder: ", 1, 120);
            int price = GetTicketPrice(age);
            string type = GetTicketType(age);
            Console.WriteLine("\n" + $"Biljett pris: {price}kr ({type})");
        }
        public static void CheckTicketPriceForMultiplePersons(int numPersons)
        {
            int total = 0;
            List<int> ages = [];
            // Frågar användaren efter ålder för varje person
            for (int i = 1; i <= numPersons; i++)
            {
                int age = Utils.GetIntInput($"Ange ålder för person {i}: ", 1, 120);
                ages.Add(age);
            }
            // Tar reda på priset för varje person baserat på ålder och plusar det på summan
            foreach (int age in ages)
            {
                int price = GetTicketPrice(age);
                total += price;
            }

            int numStandardTickets = 0;
            int numYouthTickets = 0;
            int numSeniorTickets = 0;
            // Tar reda på varje persons biljett typ baserat på ålder och sparar det
            foreach (int age in ages)
            {
                string type = GetTicketType(age);
                if (type == "standard")
                {
                    numStandardTickets++;
                }
                else if (type == "ungdom")
                {
                    numYouthTickets++;
                }
                else if (type == "pensionär")
                {
                    numSeniorTickets++;
                }
            }
            // Skriver ut summering av antalet av varje biljett typ och totala kostnaden för hela sällskapet
            Console.WriteLine("\n" + $"Standard (120kr): x{numStandardTickets}");
            Console.WriteLine($"Ungdom (80kr): x{numYouthTickets}");
            Console.WriteLine($"Pensionär (90kr): x{numSeniorTickets}");
            Console.WriteLine($"Total pris för {numPersons} personer: {total}kr");
        }
        // Returnerar biljett pris baserat på ålder
        public static int GetTicketPrice(int age)
        {
            if (age < 20)
            {
                return 80;
            }
            else if (age > 64)
            {
                return 90;
            }
            else
            {
                return 120;
            }
        }
        // Returnerar biljett typ baserat på ålder
        public static string GetTicketType(int age)
        {
            if (age < 20)
            {
                return "ungdom";
            }
            else if (age > 64)
            {
                return "pensionär";
            }
            else
            {
                return "standard";
            }
        }
    }
}
