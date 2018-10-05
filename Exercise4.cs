using System;

class Class1
{
    public static void Main(string[] args)
    {
        /*
        Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. 
        If the user enters a value less than the speed limit, program should display Ok on the console. 
        If the value is above the speed limit, the program should calculate the number of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. 
        If the number of demerit points is above 12, the program should display License Suspended.
         */

        const int speedLimit = 35;
        var carSpeed;
        var demeritSpeed;
        var demeritPoints;


        if (carSpeed <= speedLimit)
            Console.WriteLine("OK");
        else
        {
            demeritSpeed = carSpeed - speedLimit;
            demeritPoints = demeritSpeed / 5;
            if (demeritPoints < = 12)
                Console.WriteLine("License suspended");
        }
    }
}
