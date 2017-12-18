using System;
using System.Collections.Generic;

namespace CTCI_CH1
{
    class Program
    {
        static void Main(string[] args)
        {
            //IsUniqueChecker() Text
            //Console.WriteLine("Give me some input:");
            //string input = Console.ReadLine();

            //Console.WriteLine(IsUniqueChecker(input));


            //IsPermutation

            //Console.WriteLine("Give me a string");
            //string input1 = Console.ReadLine();
            //Console.WriteLine("And another");
            //string input2 = Console.ReadLine();

            //Console.WriteLine(IsPermutation(input1, input2));


            //URLify
            //Console.WriteLine("Give me a string (with some spaces, if you care):");
            //string input = Console.ReadLine();

            //Console.WriteLine(URLify(input));

            ////IsPalindromePermutation

            //Console.WriteLine("Give me a string. Can be a palindrome or a permutation of one!");
            //string input = Console.ReadLine();

            //Console.WriteLine(IsPalindromePermutation(input));


            //IsPalindrome

            Console.WriteLine("Give me a string. Can be a palindrome for added boolean fun.");
            string input = Console.ReadLine();

            Console.WriteLine(IsPalindrome(input));

        }

        public static bool IsUniqueChecker(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (i != j)
                    {
                        if (input[i] == input[j])
                            return false;
                    }
                    else
                        continue;
                }
            }
            return true;
        }

        public static bool IsPermutation(string input1, string input2)
        {
            char[] sort1 = input1.ToCharArray();
            char[] sort2 = input2.ToCharArray();

            Array.Sort(sort1);
            Array.Sort(sort2);

            string sorted1 = "";
            string sorted2 = "";

            for (int i = 0; i < sort1.Length; i++)
            {
                sorted1 += sort1[i];
            }

            for (int i = 0; i < sort2.Length; i++)
            {
                sorted2 += sort2[i];
            }

            if (input1 == input2)
                return true;
            else if (sorted1 == sorted2)
                return true;
            else
                return false;
        }

        public static string URLify(string input)
        {
            string returnMe = "";

            foreach (char character in input)
            {
                if (character == ' ')
                {
                    returnMe += "%20";
                }
                else
                    returnMe += character;
            }
            return returnMe;
        }

        public static bool IsPalindromePermutation(string input)
        {
            input = input.Replace(" ", "").ToLower();
            Dictionary<char, int> palindromeChecker = new Dictionary<char, int>();

            foreach (char character in input)
            {
                if (palindromeChecker.ContainsKey(character))
                    palindromeChecker[character]++;
                else
                    palindromeChecker.Add(character, 1);
            }

            foreach (var pair in palindromeChecker)
            {
                bool foundOdd = false;
                if (pair.Value % 2 == 0)
                    continue;
                else if (pair.Value % 2 == 1)
                {
                    if (foundOdd)
                        return false;
                    else
                        foundOdd = true;
                }
            }
            return true;
        }

        public static bool IsPalindrome(string input)
        {
            input = input.ToLower().Replace(" ", "");
            bool isOdd = false;

            if (input.Length % 2 == 1)
                isOdd = true;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == input[input.Length - i])
                    continue;
                else
                    return false;
            }
            return true;
        }

    }
}
