using System;

namespace generics
{
    public class Calculator
    {
        public static bool AreEqual<T>(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            bool Equal = Calculator.AreEqual<string>("AB", "AB");
            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }
        }
    }
}
