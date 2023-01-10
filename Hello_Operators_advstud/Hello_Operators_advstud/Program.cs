using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Operators_advstud
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MyMax = 1000;

            Random random = new Random();
            // random.Next(MaxValue) returns a 32-bit signed integer that is greater than or equal to 0 and less than MaxValue
            int Guess_number = random.Next(MyMax) + 1;
            // implement input of number and comparison result message in the while circle with  comparison condition


            Console.WriteLine(" Тебе загадали число. Попробуй его отгадать! ");

            while (true)
            {
                int i = int.Parse(Console.ReadLine());

               
                if(i < Guess_number)
                {
                    Console.WriteLine(" Попробуй большее число. ");
                }
                else if (i > Guess_number)
                {
                    Console.WriteLine(" Попробуй меньшее число. ");
                }
                else if (i == Guess_number)
                {
                    Console.WriteLine("{0} -  Это верное число! " , i);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
