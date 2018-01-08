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
                var num1 = Console.ReadLine();
                int num1digits = num1.ToString().Length;

                Console.WriteLine("Please enter a second number with the same number of digits");
                var num2 = Console.ReadLine();
                int num2digits = num2.ToString().Length;

                if (num1digits != num2digits)
                {
                    Console.WriteLine("Please try again. Make sure each number has the same amount of digits.");
                }

                

                //validates that user entered integers
                if (int.TryParse(num1 + num2, out int number))
                {
                    Console.WriteLine("Your numbers are: {0} and {1}", num1, num2);
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
        
        private static void Comparesum(int num)
        {
            //store digits in variables
            //get sums of all digit pairs
                //get sum1 of digit1 of num1 and digit1 of num2
                //get sum2 of digit2 of num2 and digit2 of num2 
            //compare sum1 with all digit sums they are all true, or until one sum comparison is false
            //if sum1 == all the digit sums then cw"True", else cw"false"

            //if sum1 == sum2 then check if there are more digits to add, if yes then get the  if not then cw "True" 
            
            //if sum1 != sum2 then cw"False" (it doesn't matter if there are more digits to check)   

        }


    }
}




