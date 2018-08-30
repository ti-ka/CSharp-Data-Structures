using System;
using System.Collections.Generic;

namespace dotnet
{
    class DecodeWays
    {
        private static int?[] map; 

        static void test()
        {
            Console.WriteLine(num_ways("111187"));
        }

        public static int num_ways(string str) {
            map = new int?[str.Length];
            return num_ways(str, 0);
        }

        private static int num_ways(string str, int strpos) {
            
            if (str.Length == 0 || strpos == str.Length)
                return 1;

            if (str[strpos] == 0)
                return 0;

            if (map[strpos] != null) {
                return map[strpos].Value;
            }

            var result = num_ways(str, strpos + 1);

            if (strpos < str.Length - 1) {
                var lett = str.Substring(0, 2);
                var doubleDigits = int.Parse(lett);
                if (doubleDigits <= 26) {
                    result += num_ways(str, strpos + 2);
                }
            }
           
            map[strpos] = result;
            return result;
        }

        public static char convert(int num, bool uppercased) 
        {
            if (num <= 0 || num > 26) 
                throw new Exception("Invalid range " + num);

            return (char) ((uppercased ? 65 : 97) + num - 1);
        }
    
        public static int toNumber(char c) 
        {
            var isUpper = Char.IsUpper(c);
            return (int) c - (isUpper ? 65 : 97);
        }
    
    }
}
