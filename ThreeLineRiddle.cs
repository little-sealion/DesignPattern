using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern
{
    public static class ThreeLineRiddle
    {
        public async static Task Riddle()
        {
            var tasks = Enumerable.Range(0, 2)
            .Select(_ => Task.Run(() => Console.Write("*")));

            //enumerating the Enumerable, and execute task
            await Task.WhenAll(tasks);

            //tasks.Count() again enumerates the Enumerable
            System.Console.WriteLine($" {tasks.Count()} tasks!");
        }
    }
}