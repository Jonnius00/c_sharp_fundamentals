using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;
using System;

namespace MoshExercise1_fundamtionals
{
    internal class Conditionals
    {
        static void Main(string[] args)
        {

            //          Call the local functions
            //          Subtask1(); Subtask2(); Subtask3(); SpeedLimit();

            //          var loops = new Loops();
            //          loops.Exercise1(); 

            //          Lists.Exercise5();

            //          Strings.Excercise5();
            DatesTimes.DatesTimesMain();
            TimeSpans.TimeSpansMain();

/* ask a user to enter a number. The number should be between 1 to 10.
If the user enters a valid number, display "Valid" on the console.
Otherwise, display "Invalid". 
This logic is used a lot in applications
where values entered into input boxes need to be validated. */
            void Subtask1()
            {
                Console.Write("task 1: number range validation\n" + "Enter a number between 1 and 10:");
                var input = Console.ReadLine();
                int number = Convert.ToInt32(input);
                if (number >= 1 && number <= 10)
                    Console.WriteLine("Validd number\n");
                else Console.WriteLine("Invalid number" + "\n");
            }

// program takes 2 numbers from the console
// and displays the maximum of the two.
            void Subtask2()
            {
                Console.WriteLine("task 2: define a max numr");
                Console.WriteLine("enter two numbers");
                var num1 = Convert.ToDouble(Console.ReadLine());
                var num2 = Convert.ToDouble(Console.ReadLine());
                double max = (num1 > num2) ? num1 : num2;
                Console.WriteLine("max is: " + max + "\n");
            }

// ask the user to enter the width and height of an image.
// Then tell if the image is landscape or portrait.
            void Subtask3()
            {
                Console.Write("Enter width:");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter heigh:");
                int heigh = Convert.ToInt32(Console.ReadLine());

                var orientation = (width > heigh) ? ImageOrientation.Landscape : ImageOrientation.Portrait;
                Console.WriteLine("image orintation is " + orientation.ToString()); Console.WriteLine();
            }

// Program for a speed camera, asks the user to enter the speed limit.
// Once limit is set, the program asks for the speed of a car.
// If the user enters a value less than the speed limit, program should display Ok on the console.
// If the value is above the speed limit, the program should calculate the number of demerit points.
// For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
// If the number of demerit points is above 12, the program should display License Suspended.
            void SpeedLimit()
            {
                Console.Write("Speed camera is being setting up..." + "\nspecify the speed limit in km/h: ");
                int speedLimit = Convert.ToInt32(Console.ReadLine());

                Console.Write("Set up a car's current speed: ");
                int carSpeed = Convert.ToInt32(Console.ReadLine());

                const int kmPerDemeritPoint = 5;
                if (carSpeed > speedLimit)
                {
                    int diff = carSpeed - speedLimit; //diff = Math.Abs(diff);
                    var points = diff / kmPerDemeritPoint;
                    Console.WriteLine(points + " are incurred");
                    if (points > 12) Console.WriteLine("you exceeded 12 points, license are to taken off");
                }
                else Console.WriteLine("speed is within limits, ok");
            }
        }
        enum ImageOrientation { Portrait, Landscape }
    }
}