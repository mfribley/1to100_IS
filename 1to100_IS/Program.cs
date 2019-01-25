/*
   Author: Mikessa Fribley
   Date: 1/22/2019
   Comments: This C# Console application code demonstrates the use of
             an iterative statement after getting input from users.  
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

            /* 
               The try catch block will validate user input.
               If an user provides bad input, the catch block
               will handle the error and a message will be displayed.
            */
            try
            {
                // This variable will gather data from user input.
                string Input = Console.ReadLine();

                /* 
                   This variable will be used to store the value of user input
                   after the input variable is parsed to integer.
                */
                int ValueOfInput = int.Parse(Input);
                int VOI = 1;

                /*
                   This IF/ELSE IF/ELSE statement is used to conditionally
                   test the value of users input. A Do While Loop will be
                   executed for the values entered.
                */
                if ((ValueOfInput > 0) && (ValueOfInput <= 50))
                {
                    do
                    {
                        Console.WriteLine("You have entered " + ValueOfInput-- + 
                        ". This is the current integer value in the loop: " + VOI++);
                    } while (ValueOfInput > 0);

                    Console.WriteLine("Press any key to exit the application.");
                    Console.ReadKey(true);
                }

                else if ((ValueOfInput > 50) && (ValueOfInput <= 100))
                {
                    do
                    {
                        Console.WriteLine("You have entered " + ValueOfInput-- +
                        ". This is the current integer value in the loop: " + VOI++);
                    } while (ValueOfInput > 0);

                    Console.WriteLine("Press any key to exit the application.");
                    Console.ReadKey(true);
                }

                else
                {
                    Console.WriteLine("Enter an integer between 1 and 100 next time.");
                    Console.WriteLine("Press any key to exit the application.");
                    Console.ReadKey(true);
                }
            } // End of try.

            catch
            {
                Console.WriteLine("Please use an integer data type next time.");
                Console.WriteLine("Press any key to exit the application.");
                Console.ReadKey(true);
            } // End of catch.
        } // End of main.
    } // End of class.
} // End of namespace.
