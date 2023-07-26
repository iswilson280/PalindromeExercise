using System;
using System.Linq;

namespace PalindromeExercise
{
	public class PalidromeChecker
	{
        //public bool IsPalindrome(string word)
        //{
        //	string reversedWord = string.Empty;

        //	for (int i= word.Length - 1; i >= 0; i--)
        //	{
        //		reversedWord += word[i];
        //	}

        //	if (word == reversedWord)
        //	{
        //		return true;

        //	}

        //	else
        //	{
        //		return false;
        //	}


        public static bool IsAPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            // Remove non-alphanumeric characters and convert to lowercase
            string cleanedInput = new string(input.ToLower().Where(char.IsLetterOrDigit).ToArray());

            int left = 0;
            int right = cleanedInput.Length - 1;

            while (left < right)
            {
                if (cleanedInput[left] != cleanedInput[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }
    }
}

