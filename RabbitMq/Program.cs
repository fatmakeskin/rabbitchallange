using System;

namespace RabbitMq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Consumer consumer = new Consumer("fatma");

            Console.ReadKey();
            
        }
    }
}
