using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "open";
            string userGuess;
            do

            {
                // Prompt user for a guess
                Console.Write("Enter your guess: ");
                userGuess = Console.ReadLine();

                // Check if the guess is correct (case-insensitive)
                if (!string.Equals(userGuess, secretWord, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Try again");
                }
            } while (!string.Equals(userGuess, secretWord, StringComparison.OrdinalIgnoreCase)) ;

            // If the guess is correct
            Console.WriteLine("Correct!");
        }
    }
}



