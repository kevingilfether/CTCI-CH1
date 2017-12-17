using System;

namespace CTCI_CH1
{
    class Program
    {
        static void Main(string[] args)
        {

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
    }
}
