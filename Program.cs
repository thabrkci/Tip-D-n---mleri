using System;

namespace TypeTransformations
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Implicit Conversion
            Console.WriteLine("_-_Implicit Conversion_-_");

            // Variables of type byte, sbyte, short can be assigned to int because it's a larger type.
            byte a = 5;
            sbyte b = 30;
            short c = 10;
            int d = a + b + c;
            Console.WriteLine("d:" + d);

            // A value of int can be assigned to long, which is a larger type.
            long h = d;
            Console.WriteLine("h:" + h);

            // A value of long can be assigned to float, which is a larger type.
            float i = h;
            Console.WriteLine("i:" + i);

            // Adding int with string and char, resulting in an assignment to the object type.
            string E = "Taha";
            char f = 'B';
            object g = E + f + d;
            Console.WriteLine("g:" + g);

            // Explicit Conversion
            Console.WriteLine("_-_Explicit Conversion_-_");

            // A value of int can be explicitly converted to byte.
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:" + y);

            // A value of int can be explicitly converted to byte with potential data loss.
            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t:" + t);

            // Float can be explicitly converted to byte with losing the decimal part.
            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:" + v);

            // ToString Method
            Console.WriteLine("[ToString Method]");

            // An int value can be converted to a string.
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:" + yy);

            // A float value can be converted to a string.
            string zz = 12.5f.ToString();
            Console.WriteLine("zz:" + zz);

            // System Convert
            Console.WriteLine("[System Convert]");

            // String values can be converted to int using the Convert class.
            string s1 = "10", s2 = "20";
            int number1, number2;
            int Total;

            number1 = Convert.ToInt32(s1);
            number2 = Convert.ToInt32(s2);

            // The converted values can be summed.
            Total = number1 + number2;
            Console.WriteLine("Total:" + Total);

            // Parse Method
            Console.WriteLine("[Parse Method]");

            // Using the Parse method to convert string expressions to numerical types.
            ParseMethod();

            static void ParseMethod()
            {
                string text1 = "10";
                string text2 = "20.35";
                int digit1;
                double double32;

                // Using Parse method to convert a string expression to int.
                digit1 = Int32.Parse(text1);
                Console.WriteLine("digit1 :" + digit1);

                // Using Parse method to convert a string expression to double.
                double32 = Double.Parse(text2);
                Console.WriteLine("double32 :" + double32);
            }
        }
    }
}
