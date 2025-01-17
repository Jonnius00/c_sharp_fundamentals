using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshExercise1_fundamtionals
{
    internal class Lists
    {
/*
When you post a message on Facebook, depending on the number of
people who like your post, Facebook shows different infos.

If no one likes your post, it doesn't display anything.
If only 1 person do it, FB displays: [Friend's Name] liked your post.
If 2 people, FB displays: [Friend 1] and [Friend 2] like your post.
If more than 2 people like your post, FB displays: 
    [Friend 1], [Friend 2] and [Number of Other People] others like your post.

Write a program continuously asks the user to enter different names, 
    until the user presses Enter (without supplying a name). 
Depending on the number of names provided, 
    display a message based on the above pattern. 
*/
        public static void Exercise1()
        {
            var names = new List<string>();
            Console.WriteLine("continuously enter a FB user name or press Enter to stop: ");
            string? input;
            do
            {
                input = Console.ReadLine();
                names.Add(input);
                
            }       
            while (!String.IsNullOrWhiteSpace(input));

            names.RemoveAll(String.IsNullOrWhiteSpace);
            int cnt = names.Count();
            switch (cnt)
            {
                case 0: Console.WriteLine("no likes at all"); break;
                case 1: Console.WriteLine(names[0] + " liked"); break;
                case 2: Console.WriteLine("{0} and {1} liked your post", 
                                        names[0], names[1]); break;
                default: Console.WriteLine();
                    Console.WriteLine("{0}, {1} and {2} others like your post", 
                                        names[0], names[1], names.Count - 2); break;
            }
        }

/// <summary>
/// Ask the user to enter their name. 
/// Use an array to reverse the name and then store the result in a new string. 
/// Display the reversed name on the console.
/// </summary>
        public static void Exercise2()
        {   Console.Write("enter your name ");
            
            // VARIANT 1
            //string? input = Console.ReadLine();
            //char[] name1 = input.ToCharArray();
            char[] names1 = Console.ReadLine().ToCharArray();
            Array.Reverse(names1);
            Console.WriteLine("Reversed name using Array.Reverse(): " + new string(names1));

            // VARIANT 2
            string? input = Console.ReadLine();
            var names2 = new char[input.Length];
            for (int i = input.Length; i>0; i--)
            // takes last char of input and assigns it to first char of name2
                names2[input.Length - i] = input[i-1];
            Console.WriteLine("Reversed name via loop iteration: " + new string(names2));
        }

        /* write a program that asks the user to enter 5 numbers. 
        If a number is previously entered, display an error message and ask the user to retry. 
        Once the user successfully enters UNIQUE numbers, sort them 
        and display the result on the console. */
        public static void Exercise3()
        { var numbers = new List<int>();

            // VARIANT 1
            Console.WriteLine("Variant 1 \n" +
                "+ enter 5 integers one by one (separated by ENTER): ");
            while (numbers.Count < 5)
            {
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                { Console.WriteLine("You've previously entered it, try aga"); continue; }
                else numbers.Add(number);
            }
            
//            if ( !numbers.All( char.IsDigit()) ) 
//                Console.WriteLine("wrong input, non digits");
            
            numbers.Sort(); Console.WriteLine("sorted input {0}", string.Join(" ", numbers));


            // VARIANT 2
            Console.WriteLine("Variant 2 \n" +
                "+ enter 5 integers one by one (separated by SPACE): ");
            String? inputs = Console.ReadLine();
            // Convert input string to list of integers
            // to able to work 2,3-digit numbers
            numbers = inputs.Split(' ')
                            .Where(x => !string.IsNullOrWhiteSpace(x))
                            .Select(int.Parse)
                            .ToList();

            // chr has a type of char
            var numberEnumerable = inputs.Select(c => int.Parse(c.ToString()));
/* use c - '0' to convert a character digit to its integer value. 
This works because characters in C# are represented by their ASCII values, 
and the ASCII value of char '0' is 48. 
Subtracting '0' from ANY digit character gives the INT value of that digit. */
            var numberEnumerable2 = inputs.Select( c => c - '0');
//          var numbers = numberEnumerable.ToList();

            // the whole input checking
            if (numbers.Count != 5)
                Console.WriteLine("wrong input, check the lenght");
            else if (inputs.Distinct().Count() != numbers.Count)
                Console.WriteLine("warning, contains duplicates");

            // check DUplicates via loop
            for (int i = 1; i < numbers.Count; i++)
            {   if (numbers[i] == numbers[i - 1])
                Console.WriteLine("1.the number {0} is duplicated", numbers[i]);
                i.ToString();
            }
            // check DUplicates via HashSet to store UNIQUE characters
            var seenCharacters = new HashSet<char>();//
            foreach (var ch in inputs)
            {   if (seenCharacters.Contains(ch))     
                    // Check if the character is already in the HashSet
                    Console.WriteLine("2.The character {0} is duplicated", ch);
                else
                    seenCharacters.Add(ch); }

            numbers.Sort();

            // Convert sorted list back to string
            var sortedInput = string.Join("", numbers);
            Console.WriteLine("sorted input: {0}", sortedInput);
        }

        /// <summary>
        /// program asks user to continuously enter a number 
        /// or type "Quit" to exit. 
        /// The list of numbers MAY include duplicates. 
        /// ONLY display the unique numbers that the user has entered.
        /// </summary>
        public static void Exercise4()
        {
            var numbers = new List<int>();
            while (true)
            { Console.WriteLine("Enter a number (or 'Quit' to exit)");
                var input = Console.ReadLine();
                if (input.ToLower() == "quit") break;
                numbers.Add(Convert.ToInt32(input));
            }
            if (numbers.Count == 0) {
        Console.WriteLine("No numbers were entered. Exiting the program."); 
                return; }

            var uniques = new List<int>();
            Console.WriteLine("\n unique numbers: ");
            foreach(int num in numbers) {
                if (!uniques.Contains(num)){
                uniques.Add(num); Console.Write(num + " "); }
            }
        }

        /// <summary>
        /// program asks user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
        /// If the list is empty or includes less than 5 numbers, 
        /// display "Invalid List" and ask the user to re-try; 
        /// otherwise, display the 3 smallest numbers in the list.
        /// </summary>
        public static void Exercise5()
        {    // Placeholder statement
            string[] elements;
            while (true) {
                Console.Write("enter a list of comma-separated numbers: "); ;
                var input = Console.ReadLine();

                // input checking
                if (!String.IsNullOrWhiteSpace(input)) {
                    elements = input.Split(',');
                    if (elements.Length >= 5) break;
                }
                // not reachable if numbers are correct
                Console.WriteLine("invalid list");
            }
            var numbers = new List<int>();
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));

            var smallest = new List<int>();
            while (smallest.Count < 3) {
                // let the first item of numbers be the smallest
                var min = numbers[0];
                foreach (var number in numbers)
                    if (number < min) min = number;
                smallest.Add(min);
                numbers.Remove(min); 
            }

            Console.WriteLine("the 3 smallest numbers are");
            foreach(var i in smallest) Console.WriteLine(i);
        }
    }
}