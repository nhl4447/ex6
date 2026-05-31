using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1.lesson7
{
    internal class bai8
    {
        // Keep one Main. Other exercises are provided as separate methods to avoid multiple top-level Main declarations.
        static void Main(string[] args)
        {
            // Example: call the first exercise (find length) to preserve original behavior
            FindLength();
        }

        // Original: to find the length of a string without using a library function.
        static void FindLength()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            int length = 0;
            foreach (char c in input)
            {
                length++;
            }
            Console.WriteLine("Length of the string: " + length);
        }

        // -to separate individual characters from a string.
        static void SeparateCharacters()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            Console.WriteLine("Individual characters:");
            foreach (char c in input)
            {
                Console.WriteLine(c);
            }
        }

        // -to print individual characters of the string in reverse order.
        static void ReverseCharacters()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            Console.WriteLine("Characters in reverse order:");
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(input[i]);
            }
        }

        // -to count the total number of words in a string.
        static void CountWords()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            int wordCount = 0;
            bool inWord = false;
            foreach (char c in input)
            {
                if (char.IsWhiteSpace(c))
                {
                    if (inWord)
                    {
                        wordCount++;
                        inWord = false;
                    }
                }
                else
                {
                    inWord = true;
                }
            }
            // Count the last word if the string doesn't end with a whitespace
            if (inWord)
            {
                wordCount++;
            }
            Console.WriteLine("Total number of words: " + wordCount);
        }

        // -to compare two strings without using a string library functions.
        static void CompareStrings()
        {
            Console.Write("Enter the first string: ");
            string str1 = Console.ReadLine();
            Console.Write("Enter the second string: ");
            string str2 = Console.ReadLine();
            bool areEqual = true;
            if (str1.Length != str2.Length)
            {
                areEqual = false;
            }
            else
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        areEqual = false;
                        break;
                    }
                }
            }
            if (areEqual)
            {
                Console.WriteLine("The strings are equal.");
            }
            else
            {
                Console.WriteLine("The strings are not equal.");
            }
        }

        // -to count the number of alphabets, digits and special characters in a string.
        static void CountCharTypes()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            int alphabetCount = 0;
            int digitCount = 0;
            int specialCharCount = 0;
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    alphabetCount++;
                }
                else if (char.IsDigit(c))
                {
                    digitCount++;
                }
                else
                {
                    specialCharCount++;
                }
            }
            Console.WriteLine("Number of alphabets: " + alphabetCount);
            Console.WriteLine("Number of digits: " + digitCount);
            Console.WriteLine("Number of special characters: " + specialCharCount);
        }

        // -to count the number of vowels or consonants in a string.
        static void CountVowelsAndConsonants()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            int vowelCount = 0;
            int consonantCount = 0;
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    char lowerChar = char.ToLower(c);
                    if (lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' || lowerChar == 'o' || lowerChar == 'u')
                    {
                        vowelCount++;
                    }
                    else
                    {
                        consonantCount++;
                    }
                }
            }
            Console.WriteLine("Number of vowels: " + vowelCount);
            Console.WriteLine("Number of consonants: " + consonantCount);
        }

        // -to check whether a given substring is present in the given string.
        static void IsSubstringPresent()
        {
            Console.Write("Enter the main string: ");
            string mainString = Console.ReadLine();
            Console.Write("Enter the substring to search: ");
            string substring = Console.ReadLine();
            bool found = false;
            for (int i = 0; i <= mainString.Length - substring.Length; i++)
            {
                int j;
                for (j = 0; j < substring.Length; j++)
                {
                    if (mainString[i + j] != substring[j])
                    {
                        break;
                    }
                }
                if (j == substring.Length)
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine("The substring is present in the main string.");
            }
            else
            {
                Console.WriteLine("The substring is not present in the main string.");
            }
        }

        // -to search for the position of a substring within a string.
        static void SubstringPosition()
        {
            Console.Write("Enter the main string: ");
            string mainString = Console.ReadLine();
            Console.Write("Enter the substring to search: ");
            string substring = Console.ReadLine();
            int position = -1;
            for (int i = 0; i <= mainString.Length - substring.Length; i++)
            {
                int j;
                for (j = 0; j < substring.Length; j++)
                {
                    if (mainString[i + j] != substring[j])
                    {
                        break;
                    }
                }
                if (j == substring.Length)
                {
                    position = i;
                    break;
                }
            }
            if (position != -1)
            {
                Console.WriteLine("The substring is found at position: " + position);
            }
            else
            {
                Console.WriteLine("The substring is not found in the main string.");
            }
        }

        // -to check whether a character is an alphabet and if so, check for the case.
        static void CheckAlphabetCase()
        {
            Console.Write("Enter a character: ");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (char.IsLetter(input))
            {
                if (char.IsUpper(input))
                {
                    Console.WriteLine("The character is an uppercase alphabet.");
                }
                else
                {
                    Console.WriteLine("The character is a lowercase alphabet.");
                }
            }
            else
            {
                Console.WriteLine("The character is not an alphabet.");
            }
        }

        // -to find the number of times a substring appears in a given string.
        static void CountSubstringOccurrences()
        {
            Console.Write("Enter the main string: ");
            string mainString = Console.ReadLine();
            Console.Write("Enter the substring to search: ");
            string substring = Console.ReadLine();
            int count = 0;
            for (int i = 0; i <= mainString.Length - substring.Length; i++)
            {
                int j;
                for (j = 0; j < substring.Length; j++)
                {
                    if (mainString[i + j] != substring[j])
                    {
                        break;
                    }
                }
                if (j == substring.Length)
                {
                    count++;
                    i += substring.Length - 1; // Move past the current match
                }
            }
            Console.WriteLine("The substring appears " + count + " times in the main string.");
        }

        // to insert a substring before the first occurrence of a string.
        static void InsertBeforeFirstOccurrence()
        {
            Console.Write("Enter the main string: ");
            string mainString = Console.ReadLine();
            Console.Write("Enter the substring to insert: ");
            string substring = Console.ReadLine();
            Console.Write("Enter the string before which to insert: ");
            string targetString = Console.ReadLine();
            int position = -1;
            for (int i = 0; i <= mainString.Length - targetString.Length; i++)
            {
                int j;
                for (j = 0; j < targetString.Length; j++)
                {
                    if (mainString[i + j] != targetString[j])
                    {
                        break;
                    }
                }
                if (j == targetString.Length)
                {
                    position = i;
                    break;
                }
            }
            if (position != -1)
            {
                string result = mainString.Substring(0, position) + substring + mainString.Substring(position);
                Console.WriteLine("Resulting string: " + result);
            }
            else
            {
                Console.WriteLine("The target string is not found in the main string.");
            }
        }
    }
}
