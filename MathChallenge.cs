using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathChallenge
{
    class Program
    {
        static bool getuserinput = true, getfirstnumber = true, getsecondnumber = true, runapp = true, calculateinput = true;
        static int num1, num2, num1digits, num2digits;

        public static void Main(string[] args)
        {                       
            while (runapp)
            {                
                while (getuserinput)
                {                    
                    //***Get first number from user***
                    while (getfirstnumber)
                    {
                        Console.WriteLine("Please enter a first number.");                        
                        string number1string = Console.ReadLine(); 
                        
                        if (int.TryParse(number1string, out num1))
                        {
                            Console.Clear();
                            getfirstnumber = false;                            
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
                    while (getsecondnumber)
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
                                getsecondnumber = false;
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
                    //***Call calculateinput method***
                    Console.WriteLine("Congrats you've verified user input and accounted for possible errors.");
                    getfirstnumber = true;
                    getsecondnumber = true;
                    Console.ReadKey();

                }

                    
                
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

            //Should be putting into array to compare digits?
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




