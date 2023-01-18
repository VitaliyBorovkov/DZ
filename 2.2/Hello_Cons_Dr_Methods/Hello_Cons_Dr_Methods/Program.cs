using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Cons_Dr_Methods
{
    class Program
    {
        
    
    
        static void Main(string[] args)
        {
            try
            {
            //Implement start position, width and height, symbol, message input 
                
                Box box = new Box();
                
                Console.SetCursorPosition(0, 0);

                Console.Write(" Введите координаты X и Y: ");
                box.StartPosition(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

                Console.Write(" Введите высоту и ширину: ");
                box.Size(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

                
                Console.WriteLine(" Выберите символ: '*', '+', '.' ");
                char symbol = char.Parse(Console.ReadLine());
                box.SetBodrer(symbol);

                Console.Write(" Введите сообщение: ");
                box.message = Console.ReadLine();
                Console.WriteLine();

                box.Draw();
                Console.ReadKey();

                //Create Box class instance


                //Use  Box.Draw() method   


                Console.SetCursorPosition(0, 8);
                Console.WriteLine("Press any key...");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }
            
        }
    }
}
