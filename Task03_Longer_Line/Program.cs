using System;

namespace Task03_Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double lineLenghtOne = LongerLine(x1, y1, x2, y2);
            double lineLenghtTwo = LongerLine(x3, y3, x4, y4);

            //Console.WriteLine(lineLenghtOne);
            //Console.WriteLine(lineLenghtTwo);
            
            if(lineLenghtOne < lineLenghtTwo)
            {
                x1 = x3;
                y1 = y3;
                x2 = x4;
                y2 = y4;
            }



            CloserToCenter(x1, y1, x2, y2);
        }

        public static double LongerLine(double x1, double y1, double x2, double y2)
        {
            double helpSideOne = 0;
            double helpSideTwo = 0;
            
            if(x1 * x2 >= 0)
            {
                helpSideOne = Math.Abs(x1 - x2);
            }
            else
            {
                helpSideOne = Math.Abs(x1) + Math.Abs(x2);
            }

            if (y1 * y2 >= 0)
            {
                helpSideTwo = Math.Abs(y1 - y2);
            }
            else
            {
                helpSideTwo = Math.Abs(y1) + Math.Abs(y2);
            }

            double result = Math.Sqrt(helpSideOne * helpSideOne + helpSideTwo * helpSideTwo);
            return result;

        }

        private static void CloserToCenter(double x1, double y1, double x2, double y2)
        {
            if (Math.Sqrt(x1 * x1 + y1 * y1) <= Math.Sqrt(x2 * x2 + y2 * y2))
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
    }
}
