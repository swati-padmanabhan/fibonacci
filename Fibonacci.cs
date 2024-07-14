using System;

public class Fibonacci
{
    public static void Main(string[] args)
    {
        int firstNumber = 0;
        int secondNumber = 1;
        int result;
        Console.WriteLine("The Fibonacci Series till are: ");
        Console.WriteLine(firstNumber + "\n" + secondNumber);
        for (int i = 0; i <= 10; i++)
        {
            result = firstNumber + secondNumber;
            Console.WriteLine(result);
            firstNumber = secondNumber;
            secondNumber = result;
        }


    }
}
