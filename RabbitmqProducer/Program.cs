using System;

namespace RabbitmqProducer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producer producer= new Producer("fatma","selam");

            Console.ReadKey();
        }
    }
}
