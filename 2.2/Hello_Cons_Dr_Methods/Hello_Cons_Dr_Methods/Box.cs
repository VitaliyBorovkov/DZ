using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Cons_Dr_Methods
{
    
    public class Box
    {
        //1.  Implement public  auto-implement properties for start position (point position)

        //auto-implement properties for width and height of the box

        //and auto-implement properties for a symbol of a given set of valid characters
        //(*, + ,.) to be used for the border 
        //and a message inside the box

        public int positionX;
        public int positionY;

        public int height;
        public int width;

        public char border;
        public char space = ' ';        
        public string message;

        public void StartPosition(int positionX, int positionY)
        {
            this.positionX = positionX;
            this.positionY = positionY;
        }

        public void Size (int height, int width)
        {
            this.height = height;
            this.width = width;
        }
        
        public void SetBodrer(char newBorder)
        {            
            while (true)
            {
                switch (newBorder)
                {
                    case '*':
                        border = '*';
                        return;
                    case '+':
                        border = '+';
                        return;
                    case '.':
                        border = '.';
                        return;
                    default:
                        Console.WriteLine(" Неизвестный символ! Попробуйте ещё раз.");
                        newBorder = char.Parse(Console.ReadLine());
                        break; 
                }      
            }
        }
        public void SetMessage(string message)
        {
            this.message = message;
        }

        //2.  Implement public Draw() method
        //to define start position, width and height, symbol, message  according to properties
        //Use Math.Min() and Math.Max() methods
        //Use draw() to draw the box with message

        public void Draw()
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(border);
            for (int i = 0; i < width; i++)
            {
                Console.Write(border);
            }
            Console.Write(border);
            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(positionX, positionY + i + 1);
                Console.Write(border);
                for (int j = 0; j < width; j++)
                {
                    Console.Write(space);
                }
                Console.Write(border);
                Console.WriteLine();
            }

            Console.SetCursorPosition(positionX, positionY + height + 1);
            Console.Write(border);
            for (int i = 0; i < width; i++)
            {
                Console.Write(border);
            }
            Console.Write(border);
            Console.WriteLine();

            Console.SetCursorPosition(positionX + 1, positionY + height / 2);
            Console.Write(message);
            Console.WriteLine(space);
        }

        //public void Draw()
        //{
        //    Console.SetCursorPosition(30,10);
        //    for (int i = 1; i <= height + positionY; i++)
        //    {
        //        //Console.SetCursorPosition(30, 10);
        //        for (int j = 1; j <= width + positionX; j++)
        //        {
        //            if (i > positionY)
        //            {
        //                if (j > positionX)
        //                {
        //                    if ((i == positionY + 1) || (i == height + positionY))
        //                    {
        //                        Console.Write(border);
        //                    }
        //                    else
        //                    {
        //                        if ((j == positionX + 1) || (j == width + positionX))
        //                        {
        //                            Console.Write(border);
        //                        }
        //                        else
        //                        {
        //                            if ((i == positionY + 2) && (j == positionX + 2))
        //                            {
        //                                Console.Write(message);
        //                                j += message.Length - 1;
        //                            }
        //                            else
        //                            {
        //                                Console.Write(space);
        //                            }
        //                        }
        //                    }
        //                }
        //                else
        //                {
        //                    Console.Write(space);
        //                }
        //            }
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //3.  Implement private method draw() with parameters 
        //for start position, width and height, symbol, message
        //Change the message in the method to return the Box square

        //Use Console.SetCursorPosition() method

        //Trim the message if necessary



    }
}
