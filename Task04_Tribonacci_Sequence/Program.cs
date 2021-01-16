using System;

namespace Task04_Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if(number == 1)
                {
                    Console.WriteLine(number);
                }
            else if(number == 2)
                {
                    Console.WriteLine("1 1");
                }
             else
            {
                int numberOne = 0;
                int numberTwo = 1;
                int numberThree = 1;

                Console.Write("1 1 ");

                for (int i = 3; i <= number; i++)
                {
                    int nextResult = NextResult(numberOne, numberTwo, numberThree);
                    Console.Write($"{nextResult} ");
                    numberOne = numberTwo;
                    numberTwo = numberThree;
                    numberThree = nextResult;
                }
            }
            
            //Console.WriteLine("Hello World!");
        }

        private static int NextResult(int numberOne, int numberTwo, int numberThree)
        {
            int result = numberOne + numberTwo + numberThree;
            return result;
        }
    }
}
