using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Exercise_3
{
    internal class Program
    {
        //Method for reverse string
        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray(); // makes the array
            Array.Reverse(charArray);
            return new string(charArray); // returns the new string
        }

        // Method for counting vowels in the string
        static int CountVowels(string input)
        {
            int count = 0;
            string vowels = "aeiouAEIOU"; // 
            foreach (char c in input) // Checks every letter in input
            {
                if (vowels.Contains(c))
                {
                    count++; // adds 1 to the count if it spots a vowel
                }
            }
            return count; // prints the count when process is done
        }

        // Method to check if a string is a palindrome
        static bool IsPalindrome(string input)
        {
            string cleanedInput = input.Replace(" ", "").ToLower(); // takes user input and makes cleaned input a variable
            string reversed = ReverseString(cleanedInput); // makes reversed a variable and uses the reverse string on the cleaned input
            return cleanedInput == reversed;
        }
        static void Main(string[] args)
        {
            // Prompts user to input a string
            Console.WriteLine("Enter a string:");
            // takes user input and makes it a string
            string userInput = Console.ReadLine();

            // Prompts the user the menu for the operations they can choose
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Reverse String");
            Console.WriteLine("2. Count Vowels");
            Console.WriteLine("3. Check Palindrome");

            // Takes users input
            int choice;
            bool isValidChoice = int.TryParse(Console.ReadLine(), out choice);
            //if user inputs any number not between 1 or 3 gives them an invalid
            if (!isValidChoice || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid choice. Please select 1, 2, or 3."); // prompts user to input a right selection
                return;
            }

            // Starts the switch for the number the user inputs
            switch (choice)
            {
                case 1: // starts the case for reversestring
                    string reversedString = ReverseString(userInput);
                    Console.WriteLine($"Reversed String: {reversedString}");
                    break;
                case 2: // starts the case for vowelcount
                    int vowelCount = CountVowels(userInput);
                    Console.WriteLine($"Number of Vowels: {vowelCount}");
                    break;
                case 3: // starts the case for palindrome
                    bool isPalindrome = IsPalindrome(userInput);
                    Console.WriteLine($"Is Palindrome: {isPalindrome}"); // Prints the string is a palindrome
                    break;
            }
         }
    }
}
