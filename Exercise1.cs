using System;

public class Class1
{
	public static void Main(string[] args)

    //Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid".
    {
        var number;
        number = Console.ReadLine("Please enter a number between 1 and 10");

        If (number <=1 && number >=10)
            Console.WriteLine("Valid");
        else
            Console.WriteLine("Invalid");
    }
}
