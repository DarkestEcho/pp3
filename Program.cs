using System;
using System.Threading;
using System.Threading.Tasks;

namespace лб3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(":)");
            new Task3().Run();
        }
    }
    public class Task3
    {
        public void Run()
        {
            var tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;
            new Task(()=>{

                while(!token.IsCancellationRequested)
                {
                    Console.WriteLine(" *-* ");
                    Thread.Sleep(400);
                }
            }).Start();
        Thread.Sleep(1000);
        tokenSource.Cancel();

        }
    }
}
