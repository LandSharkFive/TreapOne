using TreapOne;

namespace UnitTestOne
{
    [TestClass]
    public class UnitTest2
    {
        Random rnd = new Random();

        [TestMethod]
        public void TestDelete1()
        {
            Tree a = new Tree();

            for (int i = 0; i < 100; i++)
            {
                a.Insert(i);
            }

            int ht = a.Height();
            Assert.IsTrue(ht <= 16);
            Console.WriteLine("Height = {0}", ht);

            var list = a.GetList();

            Assert.AreEqual(100, list.Count);
            Assert.IsTrue(Util.IsSorted(list));

            for (int i = 0; i < 100; i++)
            {
                Assert.IsTrue(a.Contains(i));
            }

            for (int i = 0; i < 100; i++)
            {
                a.Delete(i);
            }

            list = a.GetList();

            Assert.AreEqual(0, list.Count);
            ht = a.Height();
            Assert.IsTrue(ht == 0);

            a.Clear();
        }


        [TestMethod]
        public void TestDelete2()
        {
            Tree a = new Tree();

            for (int i = 100; i > 0; i--)
            {
                a.Insert(i);
            }

            int ht = a.Height();
            Assert.IsTrue(ht <= 16);
            Console.WriteLine("Height = {0}", ht);

            var list = a.GetList();

            Assert.AreEqual(100, list.Count);
            Assert.IsTrue(Util.IsSorted(list));

            for (int i = 100; i > 0; i--)
            {
                Assert.IsTrue(a.Contains(i));
            }

            for (int i = 100; i > 0; i--)
            {
                a.Delete(i);
            }

            list = a.GetList();

            Assert.AreEqual(0, list.Count);
            ht = a.Height();
            Assert.IsTrue(ht == 0);

            a.Clear();
        }

        [TestMethod]
        public void TestDelete3()
        {
            List<int> myList = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                myList.Add(rnd.Next());
            }

            Tree a = new Tree();

            foreach (var x in myList)
            {
                a.Insert(x);
            }

            int ht = a.Height();
            Console.WriteLine("Height = {0}", ht);
            Assert.IsTrue(ht <= 18);

            var list = a.GetList();

            Assert.AreEqual(100, list.Count);
            Assert.IsTrue(Util.IsSorted(list));

            foreach (var x in myList)
            {
                Assert.IsTrue(a.Contains(x));
            }

            foreach (var x in myList)
            {
                a.Delete(x);
            }

            list = a.GetList();

            Assert.AreEqual(0, list.Count);
            ht = a.Height();
            Assert.IsTrue(ht == 0);

            a.Clear();
        }

        [TestMethod]
        public void TestDelete4()
        {
            List<int> myList = new List<int>() { 8, 2, 10, 7, 5, 6, 4, 9, 3, 1 };

            Tree a = new Tree();

            foreach (var x in myList)
            {
                a.Insert(x);
            }

            int ht = a.Height();
            Assert.IsTrue(ht <= 16);
            Console.WriteLine("Height = {0}", ht);

            var list = a.GetList();

            Assert.AreEqual(10, list.Count);
            Assert.IsTrue(Util.IsSorted(list));

            foreach (var x in myList)
            {
                Assert.IsTrue(a.Contains(x));
            }

            foreach (var x in myList)
            {
                a.Delete(x);
            }

            list = a.GetList();

            Assert.AreEqual(0, list.Count);
            ht = a.Height();
            Assert.IsTrue(ht == 0);

            a.Clear();
        }


        [TestMethod]
        public void TestDelete5()
        {
            List<int> myList = new List<int>() { 928, 160, 403, 54, 103, 394, 453, 635, 830, 301,
                883, 119, 66, 222, 766, 28, 608, 823, 988, 229 };

            List<int> myDeleted = new List<int>() { 928, 403, 103, 453, 830, 883, 66, 766, 608, 988 };

            Tree a = new Tree();

            foreach (var x in myList)
            {
                a.Insert(x);
            }

            int ht = a.Height();
            Assert.IsTrue(ht <= 16);
            Console.WriteLine("Height = {0}", ht);

            var list = a.GetList();

            Assert.AreEqual(20, list.Count);
            Assert.IsTrue(Util.IsSorted(list));

            foreach (var x in myList)
            {
                Assert.IsTrue(a.Contains(x));
            }

            foreach (var x in myDeleted)
            {
                a.Delete(x);
            }

            list = a.GetList();

            Assert.AreEqual(10, list.Count);
            Assert.IsTrue(Util.IsSorted(list));
            ht = a.Height();
            Assert.IsTrue(ht < 10);

            // true
            Assert.IsTrue(a.Contains(160));
            Assert.IsTrue(a.Contains(54));
            Assert.IsTrue(a.Contains(394));
            Assert.IsTrue(a.Contains(635));
            Assert.IsTrue(a.Contains(301));
            Assert.IsTrue(a.Contains(119));
            Assert.IsTrue(a.Contains(222));
            Assert.IsTrue(a.Contains(28));
            Assert.IsTrue(a.Contains(823));
            Assert.IsTrue(a.Contains(229));

            // false
            Assert.IsFalse(a.Contains(928));
            Assert.IsFalse(a.Contains(403));
            Assert.IsFalse(a.Contains(103));
            Assert.IsFalse(a.Contains(453));
            Assert.IsFalse(a.Contains(830));
            Assert.IsFalse(a.Contains(883));
            Assert.IsFalse(a.Contains(66));
            Assert.IsFalse(a.Contains(766));
            Assert.IsFalse(a.Contains(688));
            Assert.IsFalse(a.Contains(988));

            a.Clear();
        }

    }
}
