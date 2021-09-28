using System;

namespace Speedometer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program asks for distance and time as input and displays the speed in kilometers per hour*/
            Console.WriteLine("Enter covered distance in km: ");
            int distance = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter hours driven: ");
            int time = Convert.ToInt32(Console.ReadLine());

            double kph = distance / time;

            Console.WriteLine($"You drove at {kph} km per hour");

            


        }
    }
}
