using System;

namespace Heap
{
    public class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Value { get; set; }
        public bool IsLeaf() => Left == null && Right == null;
        public bool IsLeft() => Left != null && Right == null;

        public Node(int val, Node left, Node right)
        {
            Value = val;
            Left = left;
            Right = right;
        }

        public Node(int val, Node left)
        {
            Value = val;
            Left = left;
            Right = null;
        }

        public Node(int val)
        {
            Value = val;
            Left = null;
            Right = null;
        }

        public override string ToString() => ToString(1);

        public string ToString(int depth)
        {
            var spaces = new String(' ', depth * 2);
            if (IsLeaf())
            {
                return $"{spaces}Leaf: {Value}";
            }
            if(IsLeft())
            {
                depth--;
                return $"Value: {Value}\n{spaces}Left:\n{spaces}{Left.ToString(depth + 1)}";
            }
            return $"Value: {Value}\n{spaces}Right:\n{spaces}{Right.ToString(depth + 1)}\n{spaces}Left:\n{spaces}{Left.ToString(depth + 1)}";

        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            var node2 = new Node(1, new Node(2, new Node(6, new Node(8)), new Node(7)), new Node(3, new Node(4, new Node(9)), new Node(5)));
            Console.WriteLine($"node2: {node2}");
            Console.WriteLine("Commit");
        }
    }
}

