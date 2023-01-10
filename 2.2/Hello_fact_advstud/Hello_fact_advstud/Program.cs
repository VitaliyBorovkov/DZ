using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_fact_advstud
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define parameters to calculate the factorial of
            //Call fact() method to calculate


            Console.Write(" i = ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" Факториал числа {i} равен {Factorial(i)}");
            //Console.WriteLine(Factorial(5));
            Console.ReadLine();
        }
        

        //Create fact() method  with parameter to calculate factorial
        //Use ternary operator


        static int Factorial(int i)
        {


            //(3)
            //if (i == 1) return 1;

            //return i * Factorial(i - 1);


            //(2)
            return i == 0 ? 1 : Factorial(i - 1) * i;


            //(1)
            //int fact = 5;
            //for (int a = 1; a <= i; a++)
            //{
            //    fact *= a;
            //}
            //return fact;
        }


    }

    

}
