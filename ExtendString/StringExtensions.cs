using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtendString
{
    public class StringExtensions
    {
        public static readonly Random rdm;

        static StringExtensions()
        {
            rdm = new Random();
        }


        public static string ToRandomCase1 (this string str)
        {
            string newStr = null;

             if (str != null)
            {
                
                newStr = "";

                
                foreach (char c in str)
                {
                    string newChar = rnd.NextDouble() < 0.5
                        ? c.ToString().ToLower()
                        : c.ToString().ToUpper();

                    newStr += newChar;
                }
            }

            return newStr;
        }

         public static string ToRandomCase2 (this string str)
        {
            string newStr = null;

            if (str != null)
            {
                StringBuilder sb = new StringBuilder(str.Length);

                foreach (char c in str)
                {
                    string newChar = rnd.NextDouble() < 0.5
                        ? c.ToString().ToLower()
                        : c.ToString().ToUpper();

                    sb.Append(newChar);
                }

                newStr = sb.ToString();
            }

            return newStr;
        }

         public static string ToRandomCase3 (this string str)
        {
            string newStr = null;

            if (str != null)
            {
                StringWriter sw = new StringWriter();

                foreach (char c in str)
                {
                    string newChar = rnd.NextDouble() < 0.5
                        ? c.ToString().ToLower()
                        : c.ToString().ToUpper();

                    sw.Write(newChar);
                }

                newStr = sw.ToString();
            }
            
            return newStr;
        }

    }
}