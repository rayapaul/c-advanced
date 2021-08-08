using System;
public delegate void HelloFunctionDelegate(string Message);
namespace delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("hello from delegate");
            Hello("hi another way of declaring a delegate");
            Console.WriteLine("Hello World!");
        }

        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }
}
