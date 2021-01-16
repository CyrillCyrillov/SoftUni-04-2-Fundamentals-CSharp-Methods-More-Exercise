using System;

namespace Task01_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string numberString = Console.ReadLine();

            string result = CheckAndCalculate(type, numberString);
            Console.WriteLine(result);
        }

        private static string CheckAndCalculate(string type, string numberString)
        {
            string result = string.Empty;
            if(type == "int")
            {
                result = (int.Parse(numberString) * 2).ToString();
            }
            else if (type == "real")
            {
                result = ((double.Parse(numberString) * 1.5)).ToString("0.00");
            }
            else
            {
                result = '$' + numberString + '$';
            }

            return result;
        }
    }
}
