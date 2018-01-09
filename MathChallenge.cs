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
                //prompt user for first number
                Console.WriteLine("Please enter a number");
                //store first number entered by user
                var num1 = Console.ReadLine();
                //get number of digits of first number entered by user
                int num1digits = num1.ToString().Length;
                //prompt user for second number
                Console.WriteLine("Please enter a second number with the same number of digits");
                //store second number entered by user
                var num2 = Console.ReadLine();
                //get number of digits of second number entered by user
                int num2digits = num2.ToString().Length;
                //checks to make sure the second number is the same number of digits as the first number
                if (num1digits != num2digits)
                {
                    Console.WriteLine("Please try again. Make sure each number has the same amount of digits.");
                    Console.WriteLine("Would you like to run this program again? (Y or N)");
                    //Error: if user enters anything but a single character, it will still print the number of digits if you try running again.
                    doagain = Convert.ToChar(Console.ReadLine());
                    if (doagain != 'y' && doagain != 'Y')
                    {
                        runprogram = false;
                    }
                }

                

                //If user did enter valid integers then execute this block
                if (int.TryParse(num1 + num2, out int number))
                {
                    Console.WriteLine("digits in number1: " + num1digits);
                    Console.WriteLine("digits in number2: " + num2digits);
                    //call CompareSum method
                    CompareSum(0, 0, num1digits, num2digits);
                    //Console.WriteLine("Your numbers are: {0} and {1}", num1, num2);

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
        
        private static void CompareSum(int num1, int num2, int num1digits, int num2digits)
        {
            //each digit in variable via array
            //array for number1 and array for number2
            int[] number1array = new int[num1digits];   
            for (int index = 0; index < num1digits; index++)
            {
                number1array[index] = num1 % 10;
                num1 /= 10;
            }
            




            //sum of all digits in input


            //num1,num2 greater than 0 because you have to divide them by 10 each time throught the loop until all the digits in num1 and num2 have been added to the sum


            Console.WriteLine();
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




