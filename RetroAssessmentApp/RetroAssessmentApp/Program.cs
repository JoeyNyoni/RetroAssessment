using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RetroAssessmentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadAndWrite theFile = new ReadAndWrite();
            var readFile = theFile.Read("./StringFile.txt");
            List<string> get = readFile.ToList();

            string output = "";

            Console.WriteLine("Please insert string");
            string input = Console.ReadLine().ToUpper();

            Regex check = new Regex("^[a-zA-Z0-9]*$");

            if (input.Length == input.Distinct().Count())
            {
                if (input.Length == 5 && check.IsMatch(input))
                {
                    output = input;
                    int counter = 0;
                    for (var i = 0; i < get.Count; i++)
                    {
                        if (output == get[i])
                            counter++;
                    }

                    if (counter > 0)
                        Console.WriteLine("Match Found! " + output);
                    else
                        Console.WriteLine("Error: No match found");
                }
                else
                {
                    Console.WriteLine("Your input doesn't meet the required standards");
                }
            }
            else
            {
                throw new Exception("Wrong length. Please try again");
            }
        }
    }
}