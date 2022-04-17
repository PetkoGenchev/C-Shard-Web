using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TestingTasks
{
    public class Program
    {
        public static async Task Main()
        {
            var tasks = new List<Task>();

            for (int i = 0; i < 10; i++)
            {
                var current = i;

                var task = Task.Run(() =>
                {
                    Console.WriteLine(current);
                });

                tasks.Add(task);
            }
            await Task.WhenAll(tasks);

            Console.WriteLine("Done!");

        }
    }
}
