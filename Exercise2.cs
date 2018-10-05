using System;

class Class1
{
	public static void Main(string[] args)

    //Write a program which takes two numbers from the console and displays the maximum of the two.
    {
        var number1;
        var number2;

        number1 = Console.ReadLine("Please enter a number: ");

        number2 = Console.ReadLine("Please enter a second number: ");

        if (number1 < number2)
            Console.WriteLine(number1);
        else
            Console.WriteLine(number2);
	}
}
