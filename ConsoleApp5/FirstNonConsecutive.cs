using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml;

namespace ConsoleApp5
{
    static class FirstNonConsecutive
    {
        public static object FirstNonConsecutiveMethod()
        {
            int[] arr = new int[] { 1, 2, 3, 4,5, 6, 7, 8 };

            //var x = arr.Skip(1).FirstOrDefault(x => x != ++arr[0]);
            //2nd way

            var x = arr.Skip(1)
                       .SkipWhile((n, i) => n == ++arr[i])
                       .Cast<int?>()
                       .FirstOrDefault();

            Debug.Write(x);

            return x;
        }


        public static string NameAbbrev()
        {
            string name = "Cristiano Ronaldo";

            //Will return C.R
            return string.Join(".", name.Split(' ').Select(w => w[0])).ToUpper();
        }


        //Sum Mixed Array
        public static int SumMix()
        {
            object[] x = new object[] { "1", 2, "3", 4, 5 };
            var result = x.Select(val => val.GetType() == typeof(int) ?
                                          val : Convert.ToInt32(val))
                          .Cast<int>()
                          .ToArray()
                          .Sum();

            return result;
                           
        }
    }
}
