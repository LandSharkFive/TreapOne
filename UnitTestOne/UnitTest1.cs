using TreapOne;

namespace UnitTestOne
{
    [TestClass]
    public class UnitTest1
    {
        Random rnd = new Random();

        [TestMethod]
        public void TestInsert1()
        {
            Tree a = new Tree();

            for (int i = 0; i < 100; i++)
            {
                a.Insert(i);
            }

            int ht = a.Height();
            Console.WriteLine("Height = {0}", ht);
            Assert.IsTrue(ht <= 18);

            var list = a.GetList();

            Assert.AreEqual(100, list.Count);
            Assert.IsTrue(Util.IsSorted(list));

            for (int i = 0; i < 100; i++)
            {
                Assert.IsTrue(a.Contains(i));
            }

            a.Clear();
        }

        [TestMethod]
        public void TestInsert2()
        {
            Tree a = new Tree();

            for (int i = 100; i > 0; i--)
            {
                a.Insert(i);
            }

            int ht = a.Height();
            Console.WriteLine("Height = {0}", ht);
            Assert.IsTrue(ht <= 16);

            var list = a.GetList();

            Assert.AreEqual(100, list.Count);
            Assert.IsTrue(Util.IsSorted(list));

            for (int i = 100; i > 0; i--)
            {
                Assert.IsTrue(a.Contains(i));
            }

            a.Clear();
        }


        [TestMethod]
        public void TestInsert3()
        {
            List<int> myList = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                myList.Add(rnd.Next());
            }

            Tree a = new Tree(myList);
            int ht = a.Height();
            Assert.IsTrue(ht <= 16);
            Console.WriteLine("Height = {0}", ht);

            var list = a.GetList();

            Assert.AreEqual(100, list.Count);
            Assert.IsTrue(Util.IsSorted(list));

            foreach (var x in myList)
            {
                Assert.IsTrue(a.Contains(x));
            }

            a.Clear();
        }


        [TestMethod]
        public void TestInsert4()
        {
            List<int> myList = new List<int>() { 394, 410, 505, 801, 220, 131, 166, 240, 522, 468 };

            Tree a = new Tree(myList);
            int ht = a.Height();
            Assert.IsTrue(ht <= 8);
            Console.WriteLine("Height = {0}", ht);

            var list = a.GetList();

            Assert.AreEqual(10, list.Count);
            Assert.IsTrue(Util.IsSorted(list));

            foreach (var x in myList)
            {
                Assert.IsTrue(a.Contains(x));
            }

            a.Clear();
        }

        [TestMethod]
        public void TestInsert5()
        {
            List<int> myList = new List<int>() { 782, 536, 158, 826, 208, 700, 274, 373, 683, 669, 
                414, 183, 911, 62, 61, 532, 619, 626, 246, 312 };

            Tree a = new Tree(myList);
            int ht = a.Height();
            Console.WriteLine("Height = {0}", ht);
            Assert.IsTrue(ht <= 10);

            var list = a.GetList();

            Assert.AreEqual(20, list.Count);
            Assert.IsTrue(Util.IsSorted(list));

            foreach (var x in myList)
            {
                Assert.IsTrue(a.Contains(x));
            }

            a.Clear();
        }

    }
}