namespace TreapOne
{
    public static class Util
    {
        /// <summary>
        /// Print List
        /// </summary>
        /// <param name="a">list</param>
        public static void PrintList(this List<int> a)
        {
            foreach (var x in a)
            {
                Console.Write(x);
                Console.Write(" ");
            }
        }

        /// <summary>
        /// Is List sorted?
        /// </summary>
        /// <param name="a">list</param>
        /// <returns>bool</returns>
        public static bool IsSorted(List<int> a)
        {
            for (int i = 1; i < a.Count; i++)
            {
                if (a[i - 1] > a[i])
                {
                    return false;
                }
            }

            return true;
        }


    }
}
