using System;

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

            if (input1 == input2)
                return true;
            else if (sort1 == sort2)
                return true;
            else
                return false;
        }
    }
}
