using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshExercise1_fundamtionals
{
    internal class Strings
    {
/* Ask the user to enter a few numbers separated by a hyphen. 
Work out if the numbers are consecutive. 
For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
display a message: "Consecutive"; otherwise, display "Not Consecutive". */
        public static void Excercise1() {
            Console.Write("Enter integer numbers divided by ' - ' : ");
            var input = Console.ReadLine();        // still string
            var numbers = new List<int>();
            foreach (var num in input.Split('-')) // leave only digits 
                numbers.Add(Convert.ToInt32(num));
            numbers.Sort();

            var message = "numbers are " + (IsConsecutive(numbers) ? "Consecutive" : "Non-consecutive");
            Console.WriteLine(message);
        }
        public static bool IsConsecutive(List<int> numbers) {
            var isConsecutive = true;
            for (var i = 1; i < numbers.Count; i++)   // starts from 2.position
            {   if (numbers[i] != numbers[i - 1] + 1) // the simplest consequence
                {                              // current differs from prev by 1
                    isConsecutive = false; break;
                }
            }
            return isConsecutive;
        }

/* Ask user to enter a few numbers separated by a hyphen.
If a use presses Enter without supplying an input, exit immediately.
 Otherwise, check entered sequence if it has any duplcicates.
if so, display a warning message in console */
        public static void Excercise2() {

            Console.Write("Funding duplicates.\n Enter a few numbers eg 1-2-3-4: ");
            string? input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input)) {
                Console.WriteLine("empty input, exiting..."); return; }

            var numbers = new List<int>();
            foreach (var num in input.Split('-')) 
                numbers.Add(Convert.ToInt32(num));

            var uniques = new List<int>();
            bool includeDuplicates = false;
            foreach (int num in numbers) {
                if (!uniques.Contains(num)) uniques.Add(num);
                else includeDuplicates = true; break;
            }

            if (includeDuplicates) Console.WriteLine("Duplicates found");
        }

/* ask a user to enter a time value in the 24-hour time format (e.g. 19:00).
Time period should be btw 00.00 and 23.00.
IF the entered value is valid, display OK, otherwise show Invalid time.
If no value were provided, consider it as is invalid value. */
        public static void Excercise3()
        {
            Console.Write("Checking time format.\nEnter time: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input)) { 
                Console.WriteLine("=> Invalid time format"); return; }

            var components = input.Split(':');
            if (components.Length != 2) {
                Console.WriteLine("=> Invalid time format"); return; }

            try {
                var hours = Convert.ToInt16(components[0]);
                var minutes = Convert.ToInt16(components[1]);
                if ( (hours>=0) && (hours<=23) && (minutes>=0) && (minutes<=59) )
                    Console.WriteLine($"Entered time is valid {hours}:{minutes}");
            }
            catch { Console.WriteLine("=> Invalid time format entered"); }
        }

/* Ask user to enter a few words separated by a space. 
Use these words to create a variable name with PascalCase convention.
F.ex., if the user types "number of students" - display "NumberOfStudents" in console 
Make sure the program is not dependent on the casing of the input.
If input is "NUMBER OF STUDENTS", it should still display "NumberOfStudents".
IF no words provided in the input, print out an error "Error" */
        public static void Excercise4()
        {
            Console.WriteLine("Converting to PascalCase." +
                "\nEnter a phrase eg: Who controls the past, controls the future: ");
            string? input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input)) {
                Console.WriteLine("empty input, exiting..."); return; }

            string variableName = "";
            foreach ( string word in input.Split(" ") ) 
            {
                string wordPascal = char.ToUpper(word[0])
                    + word.ToLower().Substring(1);
                variableName += wordPascal;
            }
            Console.WriteLine($"result => {variableName}");
        }

        /* Ask user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. 
        If user enters "Inadequate" - the code should display 6 on the console.
        Make sure the program calculates number of vowels irrespective of case of the word.
        (eg "Inadequate", "inadequate" and "INADEQUATE" all include 6 vowels). */
        public static void Excercise5()
        {
            Console.WriteLine("Counting vowels.\nEnter a word: ");
            string? input = Console.ReadLine().ToLower();
            if (String.IsNullOrWhiteSpace(input))
            {  Console.WriteLine("empty input, exiting..."); return; }
            
            var vowels = new List<char>(new char[]{'a','e','i','o','u'});
            int vowelsCount = 0;
            foreach (var chr in input) {
                if (vowels.Contains(chr)) vowelsCount++; }
            
            Console.WriteLine($"amount of vowels is {vowelsCount}");
        }
    }
}