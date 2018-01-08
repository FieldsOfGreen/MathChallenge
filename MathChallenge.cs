using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MathChallenge
{


    class Program
    {
        public static void Main(string[] args)
        {
            bool runprogram = true;
            char doagain;



            while (runprogram)
            {

                Console.WriteLine("Please enter a number");
                var input1 = Console.ReadLine();
                int input1digits = input1.ToString().Length;

                Console.WriteLine("Please enter a second number with the same number of digits");
                //Write: how to make it so user enters a number with the SAME NUMBER OF DIGITS as the first number they enter.
                var input2 = Console.ReadLine();
                int input2digits = input2.ToString().Length;

                if (input1digits != input2digits)
                {
                    Console.WriteLine("Please try again. Make sure each number has the same amount of digits.");
                }
                    
                                
                //validates that user entered integers
                if (int.TryParse(input1 + input2, out int number1))
                {
                    Console.WriteLine("Your numbers are: {0} and {1}", input1, input2);


                }
                else
                {
                    Console.WriteLine("Some input was entered incorrectly. Please try again.");
                }

                //Allows user to run program again
                Console.WriteLine("Would you like to run this program again? (Y or N)");
                //Error: if user enters anything but a single character. 
                doagain = Convert.ToChar(Console.ReadLine());

                if (doagain != 'y' && doagain != 'Y')
                {
                    runprogram = false;
                }

            }

        }
        /*
        private static int Calculate(int num)
        {
            //Write: method for getting digits from integer, calculating sum, and comparing 

        }
        */

    }
}




