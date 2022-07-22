using System;

namespace TraineeTasks.BinaryTreeTasks
{
    public class BinaryTreeActions
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
}
