namespace TreapOne
{

    public class Tree
    {
        public Node Root;

        static Random rand = new Random();

        public Tree()
        {
            Root = null;
        }

        public Tree(int[] a)
        {
            this.AddRange(a);
        }

        public Tree(List<int> list)
        {
            this.AddRange(list);
        }

        public static Node NewNode(int key)
        {
            Node temp = new Node();
            temp.Key = key;
            temp.Priority = rand.Next();
            temp.Left = null;
            temp.Right = null;
            return temp;
        }

        public void AddRange(List<int> list)
        {
            foreach (var x in list)
            {
                this.Insert(x);
            }
        }

        public void AddRange(int[] a)
        {
            foreach (var x in a)
            {
                this.Insert(x);
            }
        }

        public void Clear()
        {
            Root = null;
        }

        public void Insert(int key)
        {
            Root = Insert(Root, key);
        }

        /// <summary>
        /// Insert key into Treap. Recursive. 
        /// </summary>
        /// <param name="node">Node</param>
        /// <param name="key">int</param>
        /// <returns>Node</returns>
        public static Node Insert(Node node, int key)
        {
            if (node == null)
            {
                return NewNode(key);
            }
            // If key is smaller than current node.
            if (key <= node.Key)
            {
                node.Left = Insert(node.Left, key);

                // Fix Heap property if it is violated
                if (node.Left.Priority > node.Priority)
                {
                    node = RotateRight(node);
                }
            }
            else
            {
                node.Right = Insert(node.Right, key);

                // Fix Heap property if it is violated 
                if (node.Right.Priority > node.Priority)
                {
                    node = RotateLeft(node);
                }
            }
            return node;
        }

        public static Node RotateRight(Node node)
        {
            Node left = node.Left;
            node.Left = left.Right;
            left.Right = node;
            return left;
        }

        public static Node RotateLeft(Node node)
        {
            Node right = node.Right;
            node.Right = right.Left;
            right.Left = node;
            return right;
        }

        public void Delete(int key)
        {
            Root = Delete(Root, key);
        }

        /// <summary>
        /// Delete key.  Recursive.
        /// </summary>
        /// <param name="node">Node</param>
        /// <param name="key">int</param>
        /// <returns>Node</returns>
        public static Node Delete(Node node, int key)
        {
            if (node == null)
            {
                return node;
            }
            if (key < node.Key)
            {
                node.Left = Delete(node.Left, key);
            }
            else if (key > node.Key)
            {
                node.Right = Delete(node.Right, key);
            }
            // IF KEY IS AT ROOT

            else if (node.Left == null)
            {
                Node temp = node.Right;
                node = temp; // Make right child as root
            }
            else if (node.Right == null)
            {
                Node temp = node.Left;
                node = temp; // Make left child as root
            }
            // If key is at root and both left and right are not NULL
            else if (node.Left.Priority < node.Right.Priority)
            {
                node = RotateLeft(node);
                node.Left = Delete(node.Left, key);
            }
            else
            {
                node = RotateRight(node);
                node.Right = Delete(node.Right, key);
            }
            return node;
        }

        public Node Search(int key)
        {
            return Search(Root, key);
        }

        /// <summary>
        /// Search for key.  Recursive.
        /// </summary>
        /// <param name="a">Node</param>
        /// <param name="key">int</param>
        /// <returns>Node</returns>
        public Node Search(Node a, int key)
        {
            if (a == null || a.Key == key)
            {
                return a;
            }

            // Key is greater than root's key
            if (a.Key < key)
            {
                return Search(a.Right, key);
            }
            // Key is smaller than the current node.
            return Search(a.Left, key);
        }

        public bool Contains(int key)
        {
            return Contains(Root, key);
        }

        public bool Contains(Node node, int key)
        {
            if (node == null)
            {
                return false;
            }
            if (node.Key == key)
            {
                return true;
            }
            else if (key < node.Key)
            {
                return Contains(node.Left, key);
            }
            else
            {
                return Contains(node.Right, key);
            }
        }

        public void PrintTree()
        {
            PrintTree(Root);
        }

        public void PrintTree(Node a)
        {
            if (a == null)
            {
                return;
            }

            PrintTree(a.Left);
            Console.Write(a.Key);
            Console.Write(" ");
            PrintTree(a.Right);
        }

        public int Height()
        {
            return Height(Root);
        }

        public int Height(Node a)
        {
            if (a == null || IsLeaf(a))
            {
                return 0;
            }

            return 1 + Math.Max(Height(a.Left), Height(a.Right));
        }

        public bool IsLeaf(Node a)
        {
            return a.Left == null && a.Right == null;
        }

        public List<int> GetList()
        {
            List<int> list = new List<int>();
            GetList(list, Root);
            return list;
        }

        public List<int> GetList(List<int> list, Node a)
        {
            if (a == null)
            {
                return list;
            }

            GetList(list, a.Left);
            list.Add(a.Key);
            GetList(list, a.Right);
            return list;
        }


    }
}