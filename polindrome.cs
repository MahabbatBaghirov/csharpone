using System;
public class Example
{
    public static void Main(string[] args)
    {
        int num, x, sum = 0, y;
        Console.Write("Enter the Number: ");
        num = int.Parse(Console.ReadLine());
        y = num;
        while (num > 0)
        {
            x = num % 10;
            sum = (sum * 10) + x;
            num = num / 10;
        }
        if (y == sum)
            Console.Write("Palindrome Number.");
        else
            Console.Write("Not a Palindrome Number.");
    }
}