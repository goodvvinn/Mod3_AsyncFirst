using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AsyncFirst
{
    public class Worker
    {
        public async Task<string> ReadFileAsync()
        {
            if (File.Exists("1.txt"))
            {
                string str = await Task.Run(() => File.ReadAllText("1.txt"));

                // Console.WriteLine(str);
                return str.ToString();

                // string str = File.ReadAllText("1.txt");
            }
            else
            {
                throw new Exception("File doesn`t exist");
            }
        }

        public async Task<string> WorldReturnsAsync()
        {
            // return await Task.FromResult("World");
            return await Task.Run(async () =>
            {
                await Task.Delay(200);
                return "World";
            });
        }

        public async Task<string> ConcatinationAsync()
        {
            var first = ReadFileAsync();
            var second = WorldReturnsAsync();
            await Task.WhenAll();

            return await Task.Run(() => string.Concat(first.ToString() + second.ToString()));
        }
    }
}
