using System;

class Program
{
    static bool IsPalindrome(int number)
    {
        string numStr = number.ToString();
        char[] charArray = numStr.ToCharArray();
        Array.Reverse(charArray);
        string reversedStr = new string(charArray);
        return numStr == reversedStr;
    }

    static int FindLargestPalindrome()
    {
        int largestPalindrome = 0;

        for (int i = 100; i < 1000; i++)
        {
            for (int j = i; j < 1000; j++)
            {
                for (int k = j; k < 1000; k++)
                {
                    int product = i * j * k;
                    if (IsPalindrome(product) && product > largestPalindrome)
                    {
                        largestPalindrome = product;
                    }
                }
            }
        }

        return largestPalindrome;
    }

    static void Main()
    {
        int result = FindLargestPalindrome();
        Console.WriteLine(result);
    }
}
