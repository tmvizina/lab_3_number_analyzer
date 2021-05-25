using System;

namespace Lab_3_Number_Analyzer
{
    class Program
    {
        static void Main(string[] args)
        {

            bool goOn = true;

            Console.WriteLine("Hello User, would you tell me your name? ");

            string username = Console.ReadLine();

            while (goOn == true)
            {


                Console.WriteLine(username + " please enter an integer between 1 and 100");

                int userInput = int.Parse(Console.ReadLine());

                //This is my validation step to put before
                if (userInput < 0 || userInput > 100)
                    Console.WriteLine(username + " this is an invalid integer");
                else
                {

                    //checks to see if odd, answers 2a
                    if (userInput % 2 != 0)
                    {
                        Console.WriteLine(username + " that was " + userInput + " and Odd");
                    }

                    //checks if even and within 2 and 26
                    else if (userInput % 2 == 0 && userInput >= 2 && userInput < 26)
                    {
                        Console.WriteLine(username + " that was " + "Even and Less than 25");
                    }

                    // checks to see if even and within 26 and 60 
                    else if (userInput % 2 == 0 && userInput >= 26 && userInput < 61)
                    {
                        Console.WriteLine(username + " that was " + "Even");
                    }

                    //checks to see if even amd greater than 60
                    else if (userInput % 2 == 0 && userInput >= 60)
                    {
                        Console.WriteLine(username + " that was " + userInput + " and Even");
                    }

                    else if (userInput % 2 != 0 && userInput >= 60)
                    {
                        Console.WriteLine(username + " that was " + userInput + " and Odd");
                    }


                }

                //I could have done a method outside of the main method and called it like we did in the method code along but I wanted to try and get it all working
                // within the main method using conditionals only for practice with these
                Console.WriteLine(username+" would you like to analyze another number? (y/n)");
                string usercontinue = Console.ReadLine();
                
                if (usercontinue=="n")
                {
                    goOn = false;

                    Console.WriteLine("Goodbye, "+ username);
                }
            }
        }
    }
}
