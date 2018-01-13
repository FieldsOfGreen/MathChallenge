using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathChallenge
{
    class Program
    {
        static bool getUserInput = true, getFirstNumber = true, getSecondNumber = true, runApp = true, valuesAreEqual = false, repeatProg = true;
        static int num1, num2, num1digits, num2digits;
        //string variables of the user inputs
        static string number1string, number2string;

        //static char[] Number1array = new char[number1string];
        //static char[] Number2array = number2string.ToCharArray();

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
                        number1string = Console.ReadLine();

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
                        number2string = Console.ReadLine();

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
                    Program CompareCall = new Program();
                    CompareCall.CompareSum(num1, num2);
                    Console.ReadKey();
                }
            }
        }
        public void CompareSum(int num1, int num2)
        {
            //***Arrays of the digits for each number entered by user***  
            char[] number1array = number1string.ToCharArray();
            for (int i = 0; i < number1string.Length; i++)
            {
                Char.GetNumericValue(number1array[i]);
                //Console.WriteLine(number1array[i]);
            }

            char[] number2array = number2string.ToCharArray();
            for (int i = 0; i < number2string.Length; i++)
            {
                Char.GetNumericValue(number2array[i]);
                //Console.WriteLine(number2array[i]);
            }

            //***Array of the sum of the first two arrays***            
            int[] number3array = new int[number1string.Length];
            for (int i = 0; i < number1string.Length; i++)
            {
                number3array[i] = number1array[i] + number2array[i];
                //***Check if all values in number3array are equal
                if (i <= i)
                {
                    valuesAreEqual = number3array[0].Equals(number3array[i]);
                    if (!valuesAreEqual)
                    {
                        Console.WriteLine("False");
                        return;
                    }
                }

            }
            Console.WriteLine("True");

            //***Steps I took***
            //put each number entered by user into an array. - DONE
            //create third array which is the sum of the first two arrays. - DONE
            //for each index in the third array if values are not equal then print false. - DONE, whoohoo!

        }
    }
}