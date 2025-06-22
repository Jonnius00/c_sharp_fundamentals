using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.IO;

namespace MoshExercise1_fundamtionals
{
    internal class Files_Folders
    {
        public static void File_processing()
        {
            // 1 - Write a program that reads a text file and displays the number of words.
            // var file_path = @"O:\EDU_IT\VStudio_projects\MoshExercise1_conditionals\TextFile1.txt";

            var relativePath = @"..\..\..\TextFile1.txt"; // Adjust the relative path as needed
            var file_path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

            if (File.Exists(file_path))
            {
                var content = File.ReadAllText(file_path);
                var words = content.Split(new char[] { ' ', '\n', '\r', '\t', '.', ',', ';', ':', '!', '?' }, 
                                          StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine($"Number of words: {words.Length}");

                // 2 - Write a program that reads a text file and displays the longest word in the file.
                var longestWord = words.OrderByDescending(w => w.Length).FirstOrDefault();
                Console.WriteLine($"Longest word: {longestWord}");
            }
        }
    }
}
