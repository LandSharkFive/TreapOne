using System.Diagnostics;

namespace TreapOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree a = new Tree();

            var timer = new Stopwatch();
            timer.Start();

            for (int i = 0; i < 100; i++)
            {
                a.Insert(i);
            }
            timer.Stop();

            TimeSpan myTime = timer.Elapsed;
            Console.Write(myTime.TotalMilliseconds);
            Console.WriteLine(" ms");

            Console.WriteLine("Height = {0}", a.Height());

            a.PrintTree();
        }
    }
}