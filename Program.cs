using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int rev = 0;

        while(num != 0)
        {
            int dig = num%10;
            rev = rev * 10 + dig;
            num = num/10;
        }

        Console.WriteLine("Reversed Number: " + rev);
    }
}