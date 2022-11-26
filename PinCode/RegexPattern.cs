using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PinCode
{
    public class RegexPattern
    {
        public static void Pattern(string pattern)
        {
            Regex code = new Regex("^[1-9]{1}[0-9]{5}$");
            bool matches = code.IsMatch(pattern);

            if (matches == true)
            {
                Console.WriteLine("Pincode is Valid");
            }
            else
            {
                Console.WriteLine("Please Enter Valid Pincode");
            }
        }


    }
}
