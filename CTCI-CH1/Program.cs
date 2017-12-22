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

            //IsPalindromePermutation

            //Console.WriteLine("Give me a string. Can be a palindrome or a permutation of one!");
            //string input = Console.ReadLine();

            //Console.WriteLine(IsPalindromePermutation(input));


            //IsPalindrome

            //Console.WriteLine("Give me a string. Can be a palindrome for added boolean fun.");
            //string input = Console.ReadLine();

            //Console.WriteLine(CoolStringMethods.IsPalindrome(input));



            //OneAwayChecker

            Console.WriteLine("Gimme a string");
            string input1 = Console.ReadLine();
            Console.WriteLine("And another!");
            string input2 = Console.ReadLine();

            Console.WriteLine(CoolStringMethods.OneAwayChecker(input1, input2));

        }

    }
}
