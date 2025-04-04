namespace BinaryTreeSort
{
    public static class BinaryTreeSorter
    {
        public static void Sort(int[] array)
        {
            Node? root = null;

            foreach (var value in array)
            {
                root = Insert(root, value);
            }

            int index = 0;
            InOrderTraversal(root, array, ref index);
        }
        private static Node Insert(Node? node, int value)
        {
            if (node == null) return new Node(value);

            if (value < node.value)
            {
                node.Left = Insert(node.Left, value);
            }
            else
            {
                node.Right = Insert(node.Right, value);
            }

            return node;
        }

        private static void InOrderTraversal(Node? node, int[] array, ref int index)
        {
            if (node == null) return;

            InOrderTraversal(node.Left, array, ref index);
            array[index++] = node.value;
            InOrderTraversal(node.Right, array, ref index);
        }


        private class Node
        {
            public readonly int value;
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(int value)
            {
                this.value = value;
                Left = null!;
                Right = null!;
            }

            public override string ToString()
            {
                return value!.ToString()! ?? "null";
            }
        }
    }

}

// создание бинарного дерева из элементов и обход его для сортировки.