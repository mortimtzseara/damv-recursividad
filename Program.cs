using System;

class Program
{
    public static void Main()
    {
        int[] arrayInt = { 1, 2, 3, 4, 5 };
        int[] arrayInt2 = { -3, 2, -7, 1, -5 };

        //Exercici 1
        Countdown(7);
        
        //Exercici 2
        Console.WriteLine(CountDigits(2550));
        
        //Exercici 3
        Console.WriteLine(AddDigits(5456));
        
        //Exercici 4
        Console.WriteLine(Swap(123456));

        //Exercici 5
        PrintForwardArray(arrayInt, 0);
        Console.WriteLine();

        PrintBackwardArray(arrayInt, arrayInt.Length - 1);
        Console.WriteLine();

        //Exercici 6
        Console.WriteLine(FindMax(arrayInt2, 0));

        //Exercici 7
        if (IsPalindrome("reconocer"))
        {
            Console.WriteLine("Is Palindrome");
        }
        else
        {
            Console.WriteLine("Is not Palindrome");
        }

        //Exercici 8
        Console.WriteLine(MCD(17, 13));

        //Exercici 9
        Console.WriteLine(DecimalToBinary(13));
    }
    public static int Countdown(int n)
    {
        if (n == 0)
        {
            Console.WriteLine(n);
            return 0;
        }
        else
        {
            Console.WriteLine(n);
            return Countdown(n - 1);
        }
    }
    public static int CountDigits(int n)
    {

        if (n < 10)
        {
            return 1;
        }
        else
        {
            return 1 + CountDigits(n / 10);
        }
    }
    public static int AddDigits(int n)
    {
        if (n < 10) return n;

        else return (n % 10) + AddDigits(n / 10);
    }
    public static int Swap(int n)
    {
        return SwapAux(n, 0);
    }
    public static int SwapAux(int n, int result)
    {
        if (n < 10) return result*10 + n;

        else
        {
            result = result * 10 + (n % 10);
            return SwapAux(n / 10, result);
        }
    }
    public static void PrintForwardArray(int[] arrayInt, int index)
    {
        if (index < arrayInt.Length)
        {
            Console.Write($"{arrayInt[index]} ");
            index++;
            PrintForwardArray(arrayInt, index);
        }
    }
    public static void PrintBackwardArray(int[] arrayInt, int index)
    {
        if (index >= 0)
        {
            Console.Write($"{arrayInt[index]} ");
            index--;
            PrintBackwardArray(arrayInt, index);
        }
    }
    public static int FindMax(int[] arrayInt, int index)
    {
        if(index == arrayInt.Length - 1) return arrayInt[index];

        int max = FindMax(arrayInt, index + 1);

        return Math.Max(max, arrayInt[index]);
 
    }
    public static bool IsPalindrome(string word)
    {
        if (word.Length == 0 || word.Length == 1) return true;
        else if (word[0] != word[word.Length-1]) return false;
        else
        {
            return IsPalindrome(word.Substring(1, word.Length-2));
        }
    }
    public static int MCD(int a, int b)
    {
        if (b == 0) return a;
        else
        {
            return MCD(b, a % b);
        }
    }
    public static string DecimalToBinary(int n)
    {
        if (n == 0) return "";

        return DecimalToBinary(n / 2) + (n % 2).ToString();
    }
}