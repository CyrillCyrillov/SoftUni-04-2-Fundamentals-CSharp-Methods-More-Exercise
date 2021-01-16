using System;

namespace Task05_Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            CheckMathSign(num1, num2, num3);
            
            //Console.WriteLine("Hello World!");
        }

        private static void CheckMathSign(int num1, int num2, int num3)
        {
            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                Console.WriteLine("zero");
            }
            else if (num1 > 0 && num2 > 0 && num3 > 0)
            {
                Console.WriteLine("positive");
            }
            else if (num1 < 0 && num2 < 0 && num3 < 0)
            {
                Console.WriteLine("negative");
            }

            ////////////////////////////////////////////////////////////////////////////

            else if (num1 > 0)
            {
                if ((num2 > 0 && num3 > 0) || (num2 < 0 && num3 < 0))
                {
                    Console.WriteLine("positive");
                }
                else
                {
                    Console.WriteLine("negative");
                }
            }
            else if (num2 > 0)
            {
                if ((num1 > 0 && num3 > 0) || (num1 < 0 && num3 < 0))
                {
                    Console.WriteLine("positive");
                }
                else
                {
                    Console.WriteLine("negative");
                }
            }
            else if (num3 > 0)
            {
                if ((num1 > 0 && num3 > 0) || (num1 < 0 && num3 < 0))
                {
                    Console.WriteLine("positive");
                }
                else
                {
                    Console.WriteLine("negative");
                }
            }

            ///////////////////////////////////////////////////////////////

            else if (num1 < 0)
            {
                if ((num2 > 0 && num3 > 0) || (num2 < 0 && num3 < 0))
                {
                    Console.WriteLine("negative");
                }
                else
                {
                    Console.WriteLine("positive");
                }
            }

            else if (num2 < 0)
            {
                if ((num1 > 0 && num3 > 0) || (num1 < 0 && num3 < 0))
                {
                    Console.WriteLine("negative");
                }
                else
                {
                    Console.WriteLine("positive");
                }
            }

            else if (num3 < 0)
            {
                if ((num1 > 0 && num3 > 0) || (num1 < 0 && num3 < 0))
                {
                    Console.WriteLine("negative");
                }
                else
                {
                    Console.WriteLine("positive");
                }
            }
        }
    }
}
