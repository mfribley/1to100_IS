/*
   Author: Mikessa Fribley
   Date: 1/22/2019
   Comments: This C# Console application code demonstrates the use of
             iterative statements after getting input from users.  
*/



using System;

namespace _1to100_IS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input.
            Console.WriteLine("Enter an integer between 1 and 100.");

            try
            {
                string Input = Console.ReadLine();

                int ValueOfInput = int.Parse(Input);
                int VOI = 1;

                if ((ValueOfInput > 0) && (ValueOfInput <= 50))
                {
                    do
                    {
                        Console.WriteLine("You have entered " + ValueOfInput-- + 
                        ". This is the current integer value in the loop: " + VOI++);
                    } while (ValueOfInput > 0);

                    Console.WriteLine("Press the 'Enter' key to exit the application.");
                    while (Console.ReadKey(true).Key != ConsoleKey.Enter);
                }

                else if ((ValueOfInput > 50) && (ValueOfInput <= 100))
                {
                    do
                    {
                        Console.WriteLine("You have entered " + ValueOfInput-- +
                        ". This is the current integer value in the loop: " + VOI++);
                    } while (ValueOfInput > 0);

                    Console.WriteLine("Press the 'Enter' key to exit the application.");
                    while (Console.ReadKey(true).Key != ConsoleKey.Enter);
                }

                else
                {
                    Console.WriteLine("Enter an integer between 0 and 100 next time.");
                    Console.WriteLine("Press the 'Enter' key to exit the application.");
                    while (Console.ReadKey(true).Key != ConsoleKey.Enter);
                }
            } // End of try.

            catch
            {
                Console.WriteLine("Please use an integer data type next time.");
                Console.WriteLine("Press the 'Enter' key to exit the application.");
                while (Console.ReadKey(true).Key != ConsoleKey.Enter);
            } // End of catch.
        } // End of main.
    } // End of class.
} // End of namespace.
