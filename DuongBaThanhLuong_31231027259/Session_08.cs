using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DuongBaThanhLuong_31231027259
{
    internal class Session_08
    {
        static void Main()
        {
            Console.Write("Enter your string: ");
            string input = Console.ReadLine();
            Console.WriteLine($"The string that you entered is: {input}");
            Console.WriteLine("Length of your string is: " + CountLength(input));
            SeperateCharacter(input);
            PrintReverseOrder(input);
            Console.WriteLine("The total number of words in your string is " + CountWords(input));
            CountAlphabetsDigitsSpecialCharacters(input);
            CountVowelsAndConsonants(input);
            CheckSubstring(input);
            Console.Write("Enter a substring that you want to check: ");
            string substr = Console.ReadLine();
            Console.WriteLine("Your string position is: " + FindSubstringPosition(substr, input)); 
            CheckAlphabetCase(input);
        }
        static int CountLength(string input)
        {
            int l = 0;
            foreach (char c in input)
            {
                l++;
            }
            return l;
        }
        static void SeperateCharacter(string input)
        {
            foreach (char c in input)
            {
                Console.WriteLine(c);
            }
        }
        static void PrintReverseOrder(string input)
        {
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();
        }
        static int CountWords(string input)
        {
            int wordCount = 0;
            bool inWord = false;

            foreach (char c in input)
            {
                if (Char.IsWhiteSpace(c))
                {
                    inWord = false;
                }
                else
                {
                    if (!inWord)
                    {
                        wordCount++;
                        inWord = true;
                    }
                }
            }
            return wordCount;
        }
        static void CountAlphabetsDigitsSpecialCharacters(string input)
        {
            int alphabet = 0;
            int digit = 0;
            int sChar = 0;
            foreach(char c in input)
            {
                if (char.IsLetter(c))
                {
                    alphabet++;
                }
                else if (char.IsDigit(c))
                {
                    digit++;
                }
                else 
                    sChar++;
            }
            Console.WriteLine($"The number of alphabets is {alphabet}, the number of digits is {digit}, the number of special characters is {sChar}");
        }
        static void CountVowelsAndConsonants (string input)
        {
            int vowels = 0;
            int consonants = 0;
            foreach (char c in input)
            {
                if ("aeoiu".Contains(c))
                {
                    vowels++;
                }
                else if (char.IsLetterOrDigit(c))
                    consonants++;
            }
            Console.WriteLine($"The number of vowels is: {vowels}, the number of consonants is {consonants}"); 
        }
        static bool CheckSubstring(string input) 
        {
            Console.Write("Enter a substring that you want to check: ");
            string substr = Console.ReadLine();
            bool isPresent = input.Contains(substr);
            Console.WriteLine("Do your substring exist in the string? " + isPresent);
            return true; 
        }
        static int FindSubstringPosition(string substr, string input)
        {
            int index = input.IndexOf(substr);
            return index;
        }
        static void CheckAlphabetCase (string input)
        {
            Console.Write("Enter your character to check: ");
            char str = char.Parse(Console.ReadLine());
            if (char.IsLetter(str))
            {
                if (char.IsUpper(str))
                {
                    Console.WriteLine("Your character is an uppercase letter");
                }
                else if (char.IsLower(str))
                {
                    Console.WriteLine("Your character is an lowercase letter");
                }
                else
                {
                    Console.WriteLine("Your character is not a letter");
                }
            }
        }
        static int CountSubstringAppearances (string input)
        {

        }
    }
}
