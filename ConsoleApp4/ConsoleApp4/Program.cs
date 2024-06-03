using System;
using System.Linq;

namespace AnagramPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string input = Console.ReadLine();

            bool result = CanFormPalindrome(input);
            if (result)
            {
                Console.WriteLine("Yes, an anagram of the string can form a palindrome.");
            }
            else
            {
                Console.WriteLine("No, an anagram of the string cannot form a palindrome.");
            }
        }

        static bool CanFormPalindrome(string str)
        {
            var charFrequency = str.GroupBy(c => c)
                                   .ToDictionary(g => g.Key, g => g.Count());

            int oddCount = charFrequency.Values.Count(freq => freq % 2 != 0);

            return oddCount <= 1;
        }
    }
}
