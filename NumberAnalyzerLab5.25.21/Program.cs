using System;

namespace NumberAnalyzerLab5._25._21
{
    class Program
    {
        static void Main(string[] args)
        {
            //The application prompts the user to enter an integer between 1 and 100.
            //and Display the associated result based on the integer range entered.

            //Program needs to 
            bool goOn = true;
            while (goOn == true)
        
            {
                Console.WriteLine("Enter a number between 1 and 100");
                //1 line string (Console.ReadLine IS a string)
                int inputNumber = int.Parse(Console.ReadLine());
                //use modulus to determine int as odd (!= = not equal to)
                if (inputNumber % 2 != 0)
                {
                    Console.WriteLine(inputNumber + " Odd");
                }
                //int is even
                else if (inputNumber % 2 == 0 && inputNumber <= 25)
                {
                    Console.WriteLine("Even, Less than 25");
                }
                else if (inputNumber % 2==0 && inputNumber >= 26 && inputNumber <= 60)
                {
                    Console.WriteLine("Even");
                }
                else if (inputNumber % 2 != 0 && inputNumber > 60)
                {
                    Console.WriteLine(inputNumber + " Odd");
                }
                goOn = GetContinue();
                {
               
                {

                }
                }
            }
            
            
        }
        //Doesn't appear to run yet - not sure why this won't prompt user.
        public static bool GetContinue()
        {
            Console.WriteLine("Would you like to continue? y/n");
            string continueAnswer = Console.ReadLine();
            if (continueAnswer.ToLower() == "y")
            {
                return true;
            }
            else if (continueAnswer.ToLower() == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input, please try again.");
                return GetContinue();
            }
        }
        
    }
}
/*/*have the program have like a while running again and then have your bool have a default be true. It then goes through your if states
            //and prompt the user if they want to go again and if not, set that bool to false
            //first if statement identify if its odd or even using the modulas statement
            //
            //Prompt user for 1-100
            //while - general used when you dont know how many times the loop will iterate
            //for loop - specify specific amount (like going from 1 to 10)
            //do while - need it to iterate at least one time
            //foreach - loop through entire list
            //if statements - if user input is odd
                //Print Odd
            else user input even
                    if input 2-15
                        //print even and less than 25
                        if input 26-60
                        print even
                    if input > 60
            print input and Even
            else input and Even

            extra challenege
            ask user to go again (y/n)*/