using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncFirst
{
    public class Tempor
    {
        public async Task TaskAsynk()
        {
            var work = new Worker();
            var first = await Task.Run(() => { return "World"; });
            var second = await work.ReadFileAsync();
            await Task.WhenAll<Task>();
            Console.WriteLine(second + " " + first);
        }
    }
}
