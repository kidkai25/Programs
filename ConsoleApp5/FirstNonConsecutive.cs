﻿using System;
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
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

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

        //Count Goods
        public static string TwoSort()
        {
            string[] s = new string[] { "bitcoin", "take" };
            var result = s.OrderBy(x => x).FirstOrDefault();
            result = string.Join("***", result.ToCharArray());
            return result;
        }

        public static string HowMuchILoveYou()
        {
            int nb_petals = 12;
            string[] arr = new string[] {"I love you",
                                 "a little",
                                 "a lot",
                                 "passionately",
                                 "madly",
                                 "not at all"};

            return arr[(nb_petals - 1) % 6];
        }

        //String smash, space
        public static string Smash()
        {
            string sentence = "";
            string[] words = new string[] { "Hello", "World" };

            foreach (string word in words)
            {
                if (sentence.Length != 0)
                {
                    sentence += " " + word;
                }
                else //This solves the problem of adding " " at the begining of the sentence
                {
                    sentence += word;
                }
            }
            return sentence;
        }

        public static string[] AddLength()
        {
            string str = "Hello World";
            return str.Split(' ').Select(s => string.Format("{0} {1}", s, s.Length)).ToArray();
            //or
            //=> str.Split(' ').Select(e => $"{e} {e.Length}").ToArray();
        }
        public static bool All(int[] arr, Func<int, bool> fun)
        {
            foreach (int n in arr)
            {
                if (!fun(n))
                {
                    return false;
                }
            }
            return true;
        }


        //Cool Dictionary
        //You're returning a single value, here it is a string.
        //The ternary operator works that way.
        //TryGetValue() does two things at once,
        //it returns whether it could find something and it also gives you the value via the out parameter, 
        //through ternary you say, if it can find something, return the given value. if not, return "Doesnt exist"
        public static string GetValue(string p = "kIdD")
        {
             
            return new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase)
            {
              { "Kidd", "Leader" },
              { "Rapper", "Cristal" }
            }.TryGetValue(p, out string value) ? value : "Doesn'tExist";
        }
    }
}
