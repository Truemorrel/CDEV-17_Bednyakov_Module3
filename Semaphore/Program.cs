using System;

namespace Semaphore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Semaphore light;
            light = Semaphore.Yellow;
            Console.WriteLine("Change the light to {0}", light);
        }
    }
    enum Semaphore : int 
    {
        Red=100,
        Yellow =200,
        Green=300
    }
}
