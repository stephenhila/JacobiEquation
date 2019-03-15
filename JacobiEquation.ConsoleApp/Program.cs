using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacobiEquation.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //string filelocation = Console.ReadLine();
                string filelocation = @"D:\Users\stephen.hila\Documents\Math Machine Problems\Jacobi Equation\input001.txt";
                using (StreamReader sr = new StreamReader(filelocation))
                {
                    //String line = sr.ReadToEnd();
                    //String line = sr.ReadLine();
                    // step 1: Read the first line
                    int header = int.Parse(sr.ReadLine());

                    double[,] arrayA = new double[header, header];

                    // step 2: Loop through the next X lines, where x = header
                    for (int row = 0; row < header; row++)
                    {
                        // step 3: Read the line <pending - add a more descriptive, non-confusing description>
                        string lineA = sr.ReadLine();
                        lineA = ReplaceRepeatingStrings(lineA, " ");

                        // step 4: Read each number in the line, by splitting using the 'space' character
                        string[] individualA = lineA.Split(' ');

                        for (int column = 0; column < individualA.Length; column++)
                        {
                            arrayA[row, column] = double.Parse(individualA[column]);
                        }
                    }

                    // step 5: Read the next line, which is B
                    string lineB = sr.ReadLine();
                    lineB = ReplaceRepeatingStrings(lineB, " ");

                    // step 4: Read each number in the line, by splitting using the 'space' character
                    string[] individualB = lineB.Split(' ');

                    double[] arrayB = new double[header];

                    for (int column = 0; column < individualB.Length; column++)
                    {
                        arrayB[column] = double.Parse(individualB[column]);
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not read the file");
            }
        }

        /// <summary>
        /// Checks if the input has repeating strings, reduces all repeats into a single instance.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <param name="repeatingString">The repeating string to check in the input.</param>
        /// <returns></returns>
        static string ReplaceRepeatingStrings(string input, string repeatingString)
        {
            while (input.Contains(repeatingString + repeatingString))
            {
                input = input.Replace(repeatingString + repeatingString, repeatingString);
            }

            return input;
        }
    }
}
