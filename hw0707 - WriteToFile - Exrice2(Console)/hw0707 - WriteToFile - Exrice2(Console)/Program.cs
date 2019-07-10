using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace hw0707___WriteToFile___Exrice2_Console_
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = WriteTill1000();
            while(!t.Wait(100))
            {
                Console.Write(".");
            };
            Console.WriteLine("Done...........................");
        }

        public static async Task WriteTill1000()
        {
            StreamWriter reader = new StreamWriter(@"C:\temp\NumberFile.txt", true);
            for (int i = 0; i <= 1000; i++)
                {
                    await reader.WriteAsync(i.ToString() + " ");
                    Thread.Sleep(5);
                }

        }
    }
}

