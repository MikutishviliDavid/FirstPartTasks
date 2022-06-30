using System;

namespace TraineeTasks
{
    public class BinaryTreeTasks
    {
        public Node<string> InitializeTree(string[] nodeValues)
        {
            if (nodeValues == null)
            {
                throw new ArgumentNullException("Argument nodeValues must not be null");
            }

            var tree = new Tree<string>();

            foreach (var item in nodeValues)
            {
                tree.Add(item);
            }

            return tree.Root;
        }

        public int GetLeafSum(ref int sum, Node<string> node)
        {

            if (node == null)
            {
                return 0;
            }

            if (node.Left == null && node.Right == null)
            {
                if (int.TryParse(node.Data, out int number))
                {
                    sum += number;
                }

            }

            GetLeafSum(ref sum, node.Left);
            GetLeafSum(ref sum, node.Right);

            return sum;
        }
    }

    public class Node<T> : IComparable
        where T : IComparable
    {
        public T Data { get; private set; }
        public Node<T> Left { get; private set; }
        public Node<T> Right { get; private set; }

        public Node(T data)
        {
            Data = data;
        }

        public Node(T data, Node<T> left, Node<T> right)
        {
            Data = data;
            Left = left;
            Right = right;
        }

        public void Add(T data)
        {
            var node = new Node<T>(data);

            if (node.Data.CompareTo(Data) == -1)
            {
                if (Left == null)
                {
                    Left = node;
                }
                else
                {
                    Left.Add(data);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = node;
                }
                else
                {
                    Right.Add(data);
                }
            }
        }

        public int CompareTo(object obj)
        {
            if (obj is Node<T>)
            {
                return Data.CompareTo(obj);
            }
            else
            {
                throw new ArgumentException("The type does not match");
            }

        }
    }

    public class Tree<T>
        where T : IComparable
    {
        public Node<T> Root { get; private set; }
        public int Count { get; private set; }

        public void Add(T data)
        {
            if (Root == null)
            {
                Root = new Node<T>(data);
                Count = 1;
                return;
            }

            Root.Add(data);
            Count++;
        }
    }
}
