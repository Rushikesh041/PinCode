﻿namespace PinCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter PINCODE : ");
            long pin = Convert.ToInt64(Console.ReadLine());
            RegexPattern.Pattern(pin);
        }
    }
}