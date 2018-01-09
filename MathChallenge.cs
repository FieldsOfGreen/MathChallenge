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
                //get first number
                Console.WriteLine("Please enter a number");
                string number1string = Console.ReadLine();
                int num1;                
                if (int.TryParse(number1string, out num1)) ;
                else
                {
                    Console.WriteLine("Please try again");
                    Console.ReadKey();
                    runprogram = false;
                }
                int num1digits = num1.ToString().Length;

                //get second number
                Console.WriteLine("Please enter a number");
                string number2string = Console.ReadLine();
                int num2;
                if (int.TryParse(number2string, out num2)) ;
                else
                {
                    Console.WriteLine("Please try again");
                    Console.ReadKey();
                    runprogram = false;
                }
                int num2digits = num2.ToString().Length;



                /*Convert.ToInt32(Console.ReadLine());
                int num1digits = num1.ToString().Length;
                //get second number
                Console.WriteLine("Please enter a second number with the same number of digits");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int num2digits = num2.ToString().Length;
                //verifies number2 is same amount of digits as number1
                if (num1digits != num2digits)
                {
                    Console.WriteLine("Please try again. Make sure each number has the same amount of digits.");
                    Console.WriteLine("Would you like to run this program again? (Y or N)");
                    //Error: if user enters anything but a single character AND it will still print the number of digits if you try running again.
                    doagain = Convert.ToChar(Console.ReadLine());
                    if (doagain != 'y' && doagain != 'Y')
                    {
                        runprogram = false;
                    }
                }

                //If user did enter valid integers then execute this block
                if (int.TryParse(num1.ToString(), out int number))
                {
                    

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
                */
            }

        }
        /*
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




            //WAIT i've been doing this wrong... should be putting into array to compare digits...
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
        */

    }
}




