using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestLibrary.Utilities
{
    public class Util
    {
        //This can be used to Implemet common libs across the framework -- Satish
        public static string RandomString()
        {
            Random rnd = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 10)
             .Select(s => s[rnd.Next(s.Length)]).ToArray());
        }
    }
}
