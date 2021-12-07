using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public static class ExtensionString
    {

        public static int Repeat(this string str, string find)
        {
            return Regex.Matches(str, find).Count;


            

            
        }
    }
}
