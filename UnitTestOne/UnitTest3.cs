using System.Diagnostics;
using TreapOne;

namespace UnitTestOne
{
    [TestClass] 
    public class UnitTest3
    {
        Random rnd = new Random();

        [TestMethod]
        public void TestTime1()
        {
            Tree a = new Tree();

            var timer = new Stopwatch();
            timer.Start();

            for (int i = 0; i < 1000;i++)
            {
                a.Insert(rnd.Next());
            }

            timer.Stop();

            TimeSpan myTime = timer.Elapsed;
            Console.Write(myTime.TotalMilliseconds);
            Console.WriteLine(" ms");

            int ht = a.Height();
            Console.WriteLine("Height = {0}", ht);
            Assert.IsTrue(ht <= 30);

            var list = a.GetList();

            Assert.AreEqual(1000, list.Count);
            Assert.IsTrue(Util.IsSorted(list));

            a.Clear();
        }

        [TestMethod]
        public void TestTime2()
        {
            Tree a = new Tree();

            var timer = new Stopwatch();
            timer.Start();

            for (int i = 0; i < 10000; i++)
            {
                a.Insert(rnd.Next());
            }

            timer.Stop();

            TimeSpan myTime = timer.Elapsed;
            Console.Write(myTime.TotalMilliseconds);
            Console.WriteLine(" ms");

            int ht = a.Height();
            Console.WriteLine("Height = {0}", ht);
            Assert.IsTrue(ht <= 35);

            var list = a.GetList();

            Assert.AreEqual(10000, list.Count);
            Assert.IsTrue(Util.IsSorted(list));

            a.Clear();
        }

        [TestMethod]
        public void TestTime3()
        {
            Tree a = new Tree();

            var timer = new Stopwatch();
            timer.Start();

            for (int i = 0; i < 100000; i++)
            {
                a.Insert(rnd.Next());
            }

            timer.Stop();

            TimeSpan myTime = timer.Elapsed;
            Console.Write(myTime.TotalMilliseconds);
            Console.WriteLine(" ms");

            int ht = a.Height();
            Console.WriteLine("Height = {0}", ht);
            Assert.IsTrue(ht <= 50);

            var list = a.GetList();

            Assert.AreEqual(100000, list.Count);
            Assert.IsTrue(Util.IsSorted(list));

            a.Clear();
        }

        [TestMethod]
        public void TestTime4()
        {
            List<int> myList = new List<int>();
            for (int i = 0; i < 100000; i++)
            {
                myList.Add(i);
            }

            int[] array = myList.ToArray(); 
            rnd.Shuffle<int>(array);

            int[] deleted = new int[array.Length];
            array.CopyTo(deleted, 0);
            rnd.Shuffle<int>(deleted);

            Tree a = new Tree();
            foreach (var x in array)
            {
                a.Insert(x);
            }

            int ht = a.Height();
            Console.WriteLine("Height = {0}", ht);
            Assert.IsTrue(ht <= 50);

            var timer = new Stopwatch();
            timer.Start();

            foreach (var x in deleted)
            {
                a.Delete(x);
            }

            timer.Stop();

            TimeSpan myTime = timer.Elapsed;
            Console.Write(myTime.TotalMilliseconds);
            Console.WriteLine(" ms");

            var result = a.GetList();
            Assert.AreEqual(0, result.Count);

            a.Clear();
        }



    }
}
