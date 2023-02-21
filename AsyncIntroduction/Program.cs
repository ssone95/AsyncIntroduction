using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncIntroduction
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("First line of text");

        //    Thread.Sleep(3000);

        //    Console.WriteLine("Second line of text");

        //    Console.ReadKey();

        //}

        static async Task Main(string[] args)
        {
            Console.WriteLine("First line of text");

            var task = DoSomeWork();

            var result = task.Result;

            Console.WriteLine("Second line of text");

            //int resultOfDoSomeWork = await result;

            Console.ReadKey();
        }

        static async Task<int> DoSomeWork()
        {
            Console.WriteLine("DoSomeWork - 1");

            await Task.Delay(5000);

            Console.WriteLine("DoSomeWork - 2");

            return 5;
        }
    }
}
