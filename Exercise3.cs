using System;

//Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.

class Class1
{
    public static void Main(string[] args)
    {
        var height;
        var width;

        height = Console.ReadLine("Enter an image height: ");
        width = Console.ReadLine("Enter an image width: ");

        if (height < width)
            Console.WriteLine("Image is landscape");
        else
            Console.WriteLine("Image is portrait");
    }
}
