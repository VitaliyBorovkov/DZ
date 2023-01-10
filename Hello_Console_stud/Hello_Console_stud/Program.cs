using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Console_stud
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            try
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(@"Please,  type the number:
                    1.  f(a,b) = |a-b| (unary)
                    2.  f(a) = a (binary)
                    3.  music
                    4.  morse sos
          
                    ");
                    try
                    {
                        a = (int)uint.Parse(Console.ReadLine());
                        switch (a)
                        {
                            case 1:
                                My_strings();
                                Console.WriteLine("");
                                break;
                            case 2:
                                My_Binary();
                                Console.WriteLine("");
                                break;
                            case 3:
                                My_music();
                                Console.WriteLine("");
                                break;
                            case 4:
                                Morse_code();
                                Console.WriteLine("");
                                break;
                            default:
                                Console.WriteLine("Exit");
                                break;
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error" + e.Message);
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Press Spacebar to exit; press any key to continue");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                while (Console.ReadKey().Key != ConsoleKey.Spacebar);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #region ToFromBinary
        static void My_Binary()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            //Implement positive integer variable input

            int hldr;
            int value;
            string str = "";
            char[] arr;
            Console.Write(" Введите число: ");
            value = Convert.ToInt32(Console.ReadLine());

            //Present it like binary string
            //   For example, 4 as 100

            string binary = Convert.ToString(value, 2);
            Console.WriteLine(" As binary: " + binary);

            //Use modulus operator to obtain the remainder  (n % 2) 
            //and divide variable by 2 in the loop

            while (value > 0)
            {
                hldr = value % 2;
                str += hldr; 
                value = value / 2;
            }
            Console.WriteLine(" Check: " + str);
                      
            //Use the ToCharArray() method to transform string to chararray

            arr = str.ToCharArray();
          
            //and Array.Reverse() method
            Array.Reverse(arr);

            Console.Write(" After reversing: ");
            Console.WriteLine(arr);
        }

       
        
        #endregion

        #region ToFromUnary
        static void My_strings()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            //Declare int and string variables for decimal and binary presentations

            int decimalPr;
            string binaryPr;

            //Implement two positive integer variables input
            int firstValue, secondValue;

            Console.Write(" Введите первое число: ");
            firstValue = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Введите второе число: ");
            secondValue = Convert.ToInt32(Console.ReadLine());

            //To present each of them in the form of unary string use for loop
            string firstTempUnary = "";

            for (int i = 0; i < firstValue; i++)
            {
                firstTempUnary += "1";

            }
            //Console.WriteLine(firstTempUnary);

            string secondTempUnary = "";

            for (int i = 0; i < secondValue; i++)
            {
                secondTempUnary += "1";
            }
            //Console.WriteLine(secondTempUnary);

            //Use concatenation of these two strings 
            //Note it is necessary to use some symbol ( for example “#”) to separate

            string sumTempUnary = firstTempUnary + "#" + secondTempUnary;
            Console.WriteLine(sumTempUnary);

            //Check the numbers on the equality 0

            if ((firstValue == 0) || (secondValue == 0))
            {
                Console.WriteLine(" Значение не может быть 0 ");
            }

            //Realize the  algorithm for replacing '1#1' to '#' by using the for loop 

            while (sumTempUnary.Contains("1#1"))
            {
                sumTempUnary = sumTempUnary.Replace("1#1", "#");
            }
            //Delete the '#' from algorithm result

            sumTempUnary = sumTempUnary.Replace("#", "");

            //Output the result 
            Console.WriteLine(sumTempUnary);
        }
        #endregion

        #region My_music
        static void My_music()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            //HappyBirthday
            Thread.Sleep(2000);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(330, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(2642, 500);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 250);
            Thread.Sleep(125);
            Console.Beep(352, 125);
            Thread.Sleep(125);
            Console.Beep(330, 500);
            Thread.Sleep(125);
            Console.Beep(297, 1000);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
        }
        #endregion

        #region Morse
        static void Morse_code()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            //Create string variable for 'sos'      

            string str = "sos";
            //char[] arr;
            //Use string array for Morse code
            string[,] Dictionary_arr = new string[,] { { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" },
            { ".-   ", "-... ", "-.-. ", "-..  ", ".    ", "..-. ", "--.  ", ".... ", "..   ", ".--- ", "-.-  ", ".-.. ", "--   ", "-.   ", "---  ", ".--. ", "--.- ", ".-.  ", "...  ", "-    ", "..-  ", "...- ", ".--  ", "-..- ", "-.-- ", "--.. ", "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----." }};
            //Use ToCharArray() method for string to copy charecters to Unicode character array

            char[] chars = str.ToCharArray();
            Console.WriteLine(" String " + str);
            Console.Write(" Character array :");

            //Use foreach loop for character array in which

            for (int i = 0; i < chars.Length; i++)
                Console.Write(" " + chars[i]);

            //Implement Console.Beep(1000, 250) for '.'
            // and Console.Beep(1000, 750) for '-'
            //Use Thread.Sleep(50) to separate sounds
            while (true)
            {
                Console.Beep(1000, 250);
                Thread.Sleep(50);
                Console.Beep(1000, 750);
                Thread.Sleep(50);
                Console.Beep(1000, 250);
                Thread.Sleep(2000);
            }
        }
        #endregion
    }
}
