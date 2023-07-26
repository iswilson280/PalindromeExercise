using System;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word or phrase to check if it's a palindrome:");
            string input = Console.ReadLine();

            bool isPalindrome = PalidromeChecker.IsAPalindrome(input);

            if (isPalindrome)
                Console.WriteLine("It's a palindrome!");
            else
                Console.WriteLine("It's not a palindrome!");

            // Wait for the user to press a key before closing the console
            Console.ReadKey();
        }
    }
}
