using System;

namespace CSharp_Net_module1_1_2_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use "Debugging" and "Watch" to study variables and constants

            //1) declare variables of all simple types:
            //bool, char, byte, sbyte, short, ushort, int, uint, long, ulong, decimal, float, double
            // their names should be: 
            //boo, ch, b, sb, sh, ush, i, ui, l, ul, de, fl, d0
            // initialize them with 1, 100, 250.7, 150, 10000, -25, -223, 300, 100000.6, 8, -33.1
            // Check results (types and values). Is possible to do initialization?
            // Fix compilation errors (change values for impossible initialization)

            bool boo = true; 
            char ch = '1';
            byte b = 250;
            sbyte sb = 127; 
            ushort ush = 10000;
            int i = -25;
            uint ui = 223;
            long l = 300;
            ulong ul = 100000;
            decimal de = 8;
            float fl = -33.1f;
            double dO = 100000.6;


            //2) declare constants of int and double. Try to change their values.

            const int a = 50;
                        
            const double d = 15.7;

            //a = 70;

            //d = a + d;

            
            //3) declare 2 variables with var. Initialize them 20 and 20.5. Check types. 
            // Try to reinitialize by 20.5 and 20 (change values). What results are there?

            var one = 20.5;

            Console.WriteLine(one.GetType());

            var two = 20;

            Console.WriteLine(two.GetType());




            // 4) declare variables of System.Int32 and System.Double.
            // Initialize them by values of i and d0. Is it possible?

            System.Int32 int_two = i;

            System.Double double_two = dO;

            if (true)
            {
                // 5) declare variables of int, char, double 
                // with names i, ch, do
                // is it possible?

                //int i;
                //char ch;
                //double dO;


                // 6) change values of variables from 1)

                boo = false;
                ch = 'A';
                b = 200;
                sb = 100;
                ush = 1000;
                i = 25;
                ui = 2230;
                l = 3001;
                ul = 10000;
                de = 80;
                fl = -332.1f;
                dO = 100000.61;
                
            }

            // 7)check values of variables from 1). Are they changed? Think, why

            Console.WriteLine(boo);
            Console.WriteLine(ch);
            Console.WriteLine(b);
            Console.WriteLine(sb);
            Console.WriteLine(ush);
            Console.WriteLine(i);
            Console.WriteLine(ui);
            Console.WriteLine(l);
            Console.WriteLine(ul);
            Console.WriteLine(de);
            Console.WriteLine(fl);
            Console.WriteLine(dO);

           
            // 8) use implicit/ explicit conversion to convert variables from 1). 
            // Is it possible? 

            // Fix compilation errors (in case of impossible conversion commemt that line).
            // int -> char

            int intValue = 5;

            char charValue = 'F';

            charValue = (char)intValue;
                        
            // bool -> short

            bool boolValue = true;

            short shortValue;
                       
            if (boolValue)
            {
                shortValue = 1;

            }
            else
            {
                shortValue = 0;
            }

            // double -> long

            double doubleValue = 1000;

            long longValue = 100000;

            longValue = (long)doubleValue;

            // float -> char 

            float floatValue = 80.5f;

            char charValue_two = 'D';

            charValue_two =(char)floatValue;

            // int to char

            int intValue_two = 4;

            char charValue_three = '^';

            charValue_three =(char)intValue_two;

            // decimal -> double

            decimal decimalValue = 120;

            double doubleValue_two = 8000;

            doubleValue_two =(double)decimalValue;

            // byte -> uint

            byte byteValue = 8;

            uint uintValue = 42380;

            uintValue = (uint)byteValue;

            // ulong -> sbyte

            ulong ulongValue = 30000;

            sbyte sbyteValue = 120;

            sbyteValue = (sbyte)ulongValue;

            // 9) and reverse conversion with fixing compilation errors.

            int intValue1 = 5;

            char charValue1 = 'F';

            intValue1 = (int)charValue1;

            


            bool boolValue1 = true;

            short shortValue1 = 9;

            if (shortValue1 == 0)
            {
                boolValue1 = false;

            }
            else
            {
                boolValue1 = true;
            }

           


            double doubleValue1 = 1000;

            long longValue1 = 100000;

            doubleValue1 = (double)longValue1;

            


            float floatValue1 = 80.5f;

            char charValue2 = 'D';

            floatValue1 = (float)charValue2;

            


            int intValue2 = 4;

            char charValue3 = '^';

            intValue2 = (int)charValue3;

            


            decimal decimalValue1 = 120;

            double doubleValue2 = 8000;

            decimalValue1 = (decimal)doubleValue2;

            


            byte byteValue1 = 8;

            uint uintValue1 = 42380;

            byteValue1 = (byte)uintValue1;

            


            ulong ulongValue1 = 30000;

            sbyte sbyteValue1 = 120;

            ulongValue = (ulong)sbyteValue;

            // 10) declare int nullable value. Initialize it with 'null'. 
            // Try to initialize variable i with 'null'. Is it possible?

            Nullable <int> f = null;

            f = null;

            Console.WriteLine();
            Console.ReadLine();

        }

    }
    
}
