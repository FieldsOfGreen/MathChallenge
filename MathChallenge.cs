using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathChallenge
{
    class Program
    {
        static bool getUserInput = true, getFirstNumber = true, getSecondNumber = true, runApp = true;
        static int num1, num2, num1digits, num2digits;

        public static void Main(string[] args)
        {
            while (runApp)
            {
                while (getUserInput)
                {
                    //***Get first number from user***
                    while (getFirstNumber)
                    {
                        Console.WriteLine("Please enter a first number.");
                        string number1string = Console.ReadLine();

                        if (int.TryParse(number1string, out num1))
                        {
                            Console.Clear();
                            getFirstNumber = false;
                        }
                        else
                        {
                            Console.WriteLine("Oops. You entered {0}.", number1string);
                            Console.WriteLine("");
                            Console.WriteLine("Make sure you enter a whole number. Please try again.");
                            Console.WriteLine("");
                        }
                    }
                    //***Get second number from user***
                    while (getSecondNumber)
                    {
                        Console.WriteLine("Your first number is: " + num1);
                        Console.WriteLine("");
                        Console.WriteLine("Please enter a second number.");
                        Console.WriteLine("Make sure the number you enter has the same amount of digits as the first number.");
                        string number2string = Console.ReadLine();

                        if (int.TryParse(number2string, out num2))
                        {
                            Console.Clear();
                            Console.WriteLine("Your numbers are {0} and {1}.", num1, num2);
                            num1digits = num1.ToString().Length;
                            num2digits = num2.ToString().Length;
                            Console.WriteLine("");
                            if (num1digits != num2digits)
                            {
                                Console.WriteLine("Uh oh! It looks like the amount of digits in the numbers you entered don't match. Please try again.");
                                Console.WriteLine("");
                            }
                            else
                            {
                                getSecondNumber = false;
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("You entered {0} and {1}.", num1, number2string);
                            Console.WriteLine("Make sure you enter a whole number. Please try again.");
                            Console.WriteLine("");
                        }
                    }
                    //***Call CompareSum method***
                    Console.WriteLine("Congrats you've verified user input.");
                    CompareSum(num1, num2, num1digits, num2digits);
                    
                    // getfirstnumber = true;
                    //getsecondnumber = true;
                    Console.ReadKey();
                }
            }
        }
        private static void CompareSum(int num1, int num2, int num1digits, int num2digits)
        {
            //***Arrays of the digits for each number entered by user***            
            int[] number1array = new int[num1digits];
            for (int index = 0; index < num1digits; index++)
            {
                number1array[index] = num1 % 10;
                num1 = num1 / 10;               
            }                       
           
            int[] number2array = new int[num2digits];
            for (int index = 0; index < num2digits; index++)
            {
                number2array[index] = num2 % 10;
                num2 = num2 / 10;                                      
            }                   
            
            //***Add all the digit pairs together***                       

            //***Compare all sums*** sum1 with all digit sums until one sum comparison is false

            //if sum1 == all the digit sums then cw"True", else cw"false"

            //if sum1 == sum2 then check if there are more digits to add, if yes then get the if not then cw "True" 

            //if sum1 != sum2 then cw"False" (it doesn't matter if there are more digits to check)   


        }


    }
}




