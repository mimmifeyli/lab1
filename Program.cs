using System;
using System.Text.RegularExpressions;
using System.Numerics; // Lägg till detta för att använda BigInteger

class Program
{
    static void Main(string[] args)
    {
        // Hårdkodad textsträng
        string input = "29535123p48723487597645723645"; // Teststräng

        // Regex för att hitta alla tal
        string pattern = @"\d+";

        // Summa för att addera talen
        BigInteger totalSum = 0; // Använd BigInteger istället för long

        // Matcha alla tal i strängen
        foreach (Match match in Regex.Matches(input, pattern))
        {
            string number = match.Value;

            // Skriv ut det matchade numret för att kontrollera
            Console.WriteLine($"Matchat nummer: {number}");

            // Försök att konvertera och lägga till talet i summan
            if (BigInteger.TryParse(number, out BigInteger num))
            {
                totalSum += num;
                Console.WriteLine($"Lagt till: {num}, ny total: {totalSum}"); // Debug-info
            }
            else
            {
                Console.WriteLine($"Kunde inte konvertera '{number}' till BigInteger."); // Debug-info
            }
        }

        // Separera med en tom rad
        Console.WriteLine();

        // Skriv ut summan av alla tal
        Console.WriteLine($"Summa = {totalSum}");
    }
}


