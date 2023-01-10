using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HelloOperators_stud
{
    class Program
    {
        static void Main(string[] args)
        {
            long a;
            Console.WriteLine(@"Please,  type the number:
            1. Farmer, wolf, goat and cabbage puzzle
            2. Console calculator
            3. Factirial calculation
            ");
            
            a = long.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Farmer_puzzle();
                    Console.WriteLine("");
                    break;
                case 2:
                    Calculator();
                    Console.WriteLine("");
                    break;
                case 3:
                    Factorial_calculation();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
        #region farmer
        static void Farmer_puzzle()
        {
            //Key sequence: 3817283 or 3827183
            // Declare 7 int variables for the input numbers and other variables
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"From one bank to another should carry a wolf, goat and cabbage. 
            At the same time can neither carry nor leave together on the banks of a wolf and a goat, 
            a goat and cabbage. You can only carry a wolf with cabbage or as each passenger separately. 
            You can do whatever how many flights. How to transport the wolf, goat and cabbage that all went well?");
            Console.WriteLine("There: farmer and wolf - 1");
            Console.WriteLine("There: farmer and cabbage - 2");
            Console.WriteLine("There: farmer and goat - 3");
            Console.WriteLine("There: farmer  - 4");
            Console.WriteLine("Back: farmer and wolf - 5");
            Console.WriteLine("Back: farmer and cabbage - 6");
            Console.WriteLine("Back: farmer and goat - 7");
            Console.WriteLine("Back: farmer  - 8");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please,  type numbers by step ");
            // Implement input and checking of the 7 numbers in the nested if-else blocks with the  Console.ForegroundColor changing

            string answer = "";
            string rightAnswer1 = "3817283";
            string rightAnswer2 = "3827183";
            string move;
            int step = 1;
            
            while (true)
            {
                Console.WriteLine(" Next move: ");
                move = Console.ReadLine();
                
                if ((Convert.ToInt32(move) < 1)||(Convert.ToInt32(move) > 8))
                {
                    continue;
                }
                if ((answer + move == rightAnswer1.Substring(0,step))||(answer + move == rightAnswer2.Substring(0, step)))
                {
                    answer += move;
                    step++;
                }
                else
                {
                    Console.WriteLine(" Wrong! Try again. ");
                }
                if ((answer == rightAnswer1)||(answer == rightAnswer2))
                {
                    Console.WriteLine(" " + answer);
                    Console.WriteLine(" Correct! ");
                    break;
                }
            }
            Console.ReadLine();
        }
        #endregion

        #region calculator
        static void Calculator()
        {
            // Set Console.ForegroundColor  value
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"Select the arithmetic operation:
            1. Multiplication 
            2. Divide 
            3. Addition 
            4. Subtraction
            5. Exponentiation ");
            // Implement option input (1,2,3,4,5)
            //     and input of  two or one numbers
            //  Perform calculations and output the result 


            char again = 'y';
            while (again == 'y')
            {

                double firstValue, secondValue, sum;
                char oper;

                try
                {
                    Console.Write(" Введите первое число: ");
                    firstValue = Convert.ToDouble(Console.ReadLine());

                    Console.Write(" Введите второе число: ");
                    secondValue = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine(" Не удалось преобразовать строку в число! Попробуйте ещё раз. ");
                    Console.ReadLine();
                    continue;
                }

                try
                {
                    Console.Write(" Введите оператор: ");
                    oper = Convert.ToChar(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine(" Неизвестный оператор! Попробуйте ещё раз. ");
                    Console.ReadLine();
                    continue;
                }

                switch (oper)
                {
                    case '+':
                        sum = firstValue + secondValue;
                        Console.WriteLine(" Сумма " + firstValue + " и " + secondValue + " равна " + sum);
                        break;

                    case '-':
                        sum = firstValue - secondValue;
                        Console.WriteLine(" Разность " + firstValue + " и " + secondValue + " равна " + sum);
                        break;

                    case '*':
                        sum = firstValue * secondValue;
                        Console.WriteLine(" Произведение " + firstValue + " и " + secondValue + " равно " + sum);
                        break;

                    case '/':
                        sum = firstValue / secondValue;
                        if (secondValue == 0)
                        {
                            Console.WriteLine(" На 0 делить нельзя! ");
                        }
                        else
                        {
                            Console.WriteLine(" Частное " + firstValue + " и " + secondValue + " равно " + sum);
                        }
                        break;
                    case '%':
                        sum = firstValue % secondValue;
                        Console.WriteLine(" Остаток от деления " + firstValue + " и " + secondValue + " равен " + sum);
                        break;
                    default:
                        Console.WriteLine(" Неизвестный оператор. ");
                        break;
                }
                Console.WriteLine(" Вы хотите продолжить работу с калькулятором?  (y / n) ");

                again = Convert.ToChar(Console.ReadLine());
            }
        }
        #endregion

        #region Factorial
        static void Factorial_calculation()
        {
            // Implement input of the number
            // Implement input the for circle to calculate factorial of the number
            // Output the result

            Console.WriteLine(" Введите число. ");

             int i = int.Parse(Console.ReadLine());

            double fact = 1;

            for (int a = 1; a <= i; a++)
            {
                fact *= a;
            }

            Console.WriteLine(fact);
            
        }
        
        #endregion
    }
   
}
