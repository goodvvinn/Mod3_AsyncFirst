using System;
using System.Threading.Tasks;

namespace AsyncFirst
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var worker = new Worker();

            // Task<string> t = worker.ReadFileAsync();
            // Task<string> s = (Task<string>)worker.WorldReturnsAsync();

            // Console.WriteLine(s.Result.ToString());
            // Task<string> result = (Task<string>)worker.ConcatinationAsync();
            // Console.WriteLine(result.Result);
            var tempor = new Tempor();
            tempor.TaskAsynk().Wait();
        }
    }
}
