using System;
using System.Collections.Generic;
using System.Text;

namespace CTCI_CH1
{
    class CoolStringMethods
    {
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

        if (isOdd)
        {
            for (int i = 0; i < ((input.Length - 1) / 2); i++)
            {
                if (input[i] == input[input.Length - i - 1])
                    continue;
                else
                    return false;
            }
        }

        for (int i = 0; i < (input.Length / 2); i++)
        {
            if (input[i] == input[input.Length - i - 1])
                continue;
            else
                return false;
        }
        return true;
    }
}
}
