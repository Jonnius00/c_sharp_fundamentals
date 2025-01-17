using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MoshExercise1_fundamtionals
{
/*    internal class Program
    {
        static void Main(string[] args)
        {
            var loops = new Loops();
            loops.Exercise1(); 
            loops.Exercise2(); 
            loops.Exercise3(); 
            loops.Exercise4();
            loops.Exercise5();
        }
    }*/

    internal class Loops
    {
/// <summary>
/// Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
/// Display the result on the console.
/// </summary>
        public void Exercise1()
        {
            var count = 0;
            for (var inc = 1; inc <= 100; inc++)
            {
                if (inc % 3 == 0) 
                    //Console.WriteLine(inc); 
                    count++;
            }
            Console.WriteLine("There are {0} numbers divisible by 0 between 1 and 100", count);
        }

/// <summary>
/// Write a program and continuously ask the user to enter a number. 
/// The loop terminates when the user enters “ok". 
/// Calculate the sum of all the previously entered numbers and display it on the console.
/// </summary>
        public void Exercise2()
        {
            var sum = 0;
            while (true)
            {
                Console.Write("Enter an integer number (or OK for exit): ");
                string? input = Console.ReadLine();

              if (input.ToLowerInvariant() == "ok" | input == null) break;
              else sum += Convert.ToInt32(input); continue;

/*                if (!input.Equals("ok", StringComparison.InvariantCultureIgnoreCase) | input != null)
                    sum += Convert.ToInt32(input);               
                else break; */

            }
            Console.WriteLine("Sum of all elements is: {0}", sum);
        }

/// <summary>
/// Write a program which takes a single argument from the console, 
/// computes the factorial and print the value on the console. 
/// For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
/// and display it as 5! = 120.
/// </summary>
        public void Exercise3()
        {
            Console.Write("Enter an integer to calculate a factorial: ");
            var num = Convert.ToInt32( Console.ReadLine() );
            var factorial = 1;                  // base case is 1
            for (var inc = 1; inc <= num; inc++) factorial *= inc;
            Console.WriteLine("factorial {0}! = {1}" , num, factorial);
        }

/// <summary>
/// Write a program that picks a random number between 1 and 10. 
/// Give the user 4 chances to guess the number. 
/// If the user guesses the number, display “You won". 
/// Otherwise, display “You lost".
/// </summary>
        public void Exercise4()
        {
            int guessed = new Random().Next(1, 10); int attempts = 4;
            Console.Write("guess a secret number between 1 and 10: ");
            do {
                var num = Convert.ToInt32(Console.ReadLine());
                if (num == guessed) { Console.WriteLine("You won"); break; }
                else
                {
                    attempts--;
                    Console.Write("try once more, you have {0} tries " , attempts);
                    //continue;
            }   }
            while (attempts > 0);
            Console.WriteLine("\nYou lost, the guessed number was {0}", guessed);
        }

/// <summary>
/// Write a program and ask the user to enter a series of numbers separated by comma. 
/// Find the maximum of the numbers and numbers and display it on the result. 
/// For example, if the user enters “5, 3, 8, 1, 4", the program should 
/// display 8 on the console.
/// </summary>
        public void Exercise5()
        {
            // bool stop = false;
            Console.Write("Enter integer values separated by comma: "); 
            string? input = Console.ReadLine();
            if (input != null)
            {
                string[] numbers = input.Split(','); // WHat about whitespeces ?
                // Let the first number be the max 
                int max = Convert.ToInt32(numbers[0]);
                foreach (string number in numbers)
                { int num = Convert.ToInt32(number); // remember numbers is still a STRING
                    if (num > max) max = num; 
                }                
                Console.WriteLine("max of those numbers is " + max);
            }
            else Console.WriteLine("entered an empty line"); ;
        }
    }
}