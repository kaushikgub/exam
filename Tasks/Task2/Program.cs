using System;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var text = "aaabbcc";
            var result = text.Rotate(1);
            Console.WriteLine(result);
        }
    }

    /* Write your code below this line*/
    public static class StrRotate
    {
        public static string Rotate(this string str, int number)
        {
            string finalStr = "";
            for (int j = 0; j < number; j++)
            {
                char[] c = str.ToCharArray();
                char save = c[0];
                for (int i = 0; i < c.Length; i++)
                {
                    if (c[i] != c[0])
                        c[i] = c[i - 1];

                    finalStr += c;
                }
            }
            return finalStr;
        }
    }
}
