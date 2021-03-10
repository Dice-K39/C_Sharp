using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            float myFloatValue = 10;
            int myIntValue = (int) myFloatValue; // casing float value to an int

            Console.WriteLine("myIntValue is " + myIntValue);
        }
    }
}
