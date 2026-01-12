using System;

class Program
{
    public static void Main()
    {
        long factorial;
        int numero;
        Console.WriteLine("Dame un número");
        numero = Int32.Parse(Console.ReadLine());

        DateTime startTime;
        startTime = DateTime.Now;

        factorial = Factorial(numero);

        DateTime endTime;
        endTime = DateTime.Now;

        TimeSpan duration = endTime - startTime;

        Console.WriteLine($"El factorial de {numero} es {factorial}");
        Console.WriteLine($"Time span: {duration}");

        //No recursivo
        startTime = DateTime.Now;

        factorial = FactorialNoRecursivo(numero);

        endTime = DateTime.Now;

        duration = endTime - startTime;

        Console.WriteLine($"El factorial de {numero} es {factorial}");
        Console.WriteLine($"Time span: {duration}");
    }
    public static long Factorial(int num)
    {
        if (num == 0) return 1;

        else {
            long resultado = num * Factorial(num - 1);
            return resultado;
        }
    }
    public static long FactorialNoRecursivo(int num)
    {
        long resultado = num;
        for(int i = 1; i < num; i++)
        {
            resultado *= i;
        }
        return resultado;
    }
}