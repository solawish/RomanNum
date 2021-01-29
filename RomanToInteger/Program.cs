using System;
using System.Collections.Generic;

namespace RomanToInteger
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("III"));
            Console.WriteLine(RomanToInt("IV"));
            Console.WriteLine(RomanToInt("IX"));
            Console.WriteLine(RomanToInt("LVIII"));
            Console.WriteLine(RomanToInt("MCMXCIV"));
            Console.ReadLine();
        }

        public static int RomanToInt(string s)
        {
            //標準
            var standard = PrepareInitList();

            var intResult = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                var tmpInt = standard[s[i]];

                if (i != s.Length - 1)
                {
                    if (standard[s[i]] < standard[s[i + 1]])
                    {
                        intResult -= tmpInt;
                    }
                    else
                    {
                        intResult += tmpInt;
                    }
                }
                else
                {
                    intResult += tmpInt;
                }
            }

            return intResult;
        }

        private static Dictionary<char, int> PrepareInitList()
        {
            var result = new Dictionary<char, int>();

            result.Add('I', 1);
            result.Add('V', 5);
            result.Add('X', 10);
            result.Add('L', 50);
            result.Add('C', 100);
            result.Add('D', 500);
            result.Add('M', 1000);

            return result;
        }
    }
}