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

        public int positionX = 10;
        public int positionY = 5;

        public int height = 7;
        public int width = 40;

        public char border;
        public char space = ' ';
        //public char star = '*';
        //public char plus = '+';
        //public char dot = '.';
        //public char dies = '#';

        public string message = " Message inside the box. ";

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

        public void SetBodrer(char symbol)
        {
            //Console.WriteLine(" Выберите символ: '*', '+', '.' " );

            switch (symbol)
            {
                case '*':
                    this.border = '*';
                    break;
                case '+':
                    this.border = '+';
                    break;
                case'.':
                    this.border = '.';
                    break;
                default:
                    Console.WriteLine(" Неизвестный символ. ");
                    break;
            }
        }

        //2.  Implement public Draw() method
        //to define start position, width and height, symbol, message  according to properties
        //Use Math.Min() and Math.Max() methods
        //Use draw() to draw the box with message

        public void Draw()
        {
            for (int i = 1; i <= height + positionY; i++)
            {
                for (int j = 1; j <= width + positionX; j++)
                {
                    if (i > positionY)
                    {
                        if (j > positionX)
                        {
                            if ((i == positionY + 1) || (i == height + positionY))
                            {

                                //Console.Write(dies);
                            }
                            else
                            {
                                if ((j == positionX + 1) || (j == width + positionX))
                                {

                                    //Console.Write(dies);
                                }
                                else
                                {
                                    //Console.Write(space);
                                }
                            }

                        }
                        else
                        {
                            //Console.Write(space);
                        }

                    }

                }
                Console.WriteLine();
            }
        }

        //3.  Implement private method draw() with parameters 
        //for start position, width and height, symbol, message
        //Change the message in the method to return the Box square
        //Use Console.SetCursorPosition() method
        //Trim the message if necessary


    }
}
