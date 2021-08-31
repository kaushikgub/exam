using System;

namespace Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = BinaryToDecimal("111");
            Console.WriteLine(result);
        }

        public static int BinaryToDecimal(string binaryNumber)
        {
            try
            {
                nint decimalValue = 0;
                nint number = nint.Parse(binaryNumber);
                int bValue = 1;
                while (number > 0)
                {
                    nint reminder = number % 10;
                    number = number / 10;
                    decimalValue += reminder * bValue;
                    bValue = bValue * 2;
                }
                return (int)decimalValue;
            }
            catch
            {
                throw new NotImplementedException();
            }

            // Write your code here
        }
    }
}
