namespace BinaryTree
{
    public class BinaryTree<T> where T : IComparable 
    {
        public BinaryTreeNode<T> RootNode { get; set; }

        public BinaryTreeNode<T> Add(BinaryTreeNode<T> node, BinaryTreeNode<T> currentNode = null)
        {
            if (RootNode == null)
            {
                node.ParentNode = null;
                return RootNode = node;
            }

            if (currentNode == null)
                currentNode = RootNode;

            node.ParentNode = currentNode;

            int result = node.Value.CompareTo(currentNode.Value);

            switch (result)
            {
                case 0:
                    return currentNode;
                case < 0:
                    return currentNode.LeftNode == null ? currentNode.LeftNode = node : Add(node, currentNode.LeftNode);
                case > 0:
                    return currentNode.RightNode == null ? currentNode.RightNode = node : Add(node, currentNode.RightNode);
            }
        }

        public BinaryTreeNode<T> Add(T value)
        {
            return Add(new BinaryTreeNode<T>(value));
        }
        public void Print()
        {
            PrintNode(RootNode);
        }

        private void PrintNode(BinaryTreeNode<T> startNode, string offset = "", Side? side = null)
        {
            if (startNode != null)
            {
                var nodeSide = side == null ? "+" : side == Side.Left ? "L" : "R";
                Console.WriteLine($"{offset} [{nodeSide}]- {startNode.Value}");
                offset += new string(' ', 3);

                PrintNode(startNode.LeftNode, offset, Side.Left);
                PrintNode(startNode.RightNode, offset, Side.Right);
            }
        }

        public BinaryTreeNode<T> Find(T value, BinaryTreeNode<T> startsWith = null)
        {
            startsWith ??= RootNode;

            int result = value.CompareTo(startsWith.Value);

            switch (result)
            {
                case 0:
                    return startsWith;
                case < 0:
                    return startsWith.LeftNode == null ? null : Find(value, startsWith.LeftNode);
                case > 0:
                    return startsWith.RightNode == null ? null : Find(value, startsWith.RightNode);
            }
        }

        public void Remove(T value)
        {
            var foundNode = Find(value);
            Remove(foundNode);
        }

        public void Remove(BinaryTreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }

            var currentNodeSide = node.GetSide;
            ////если нет подузлов удаляю
            if (node.LeftNode == null && node.RightNode == null)
            {
                if (currentNodeSide == Side.Left)
                {
                    node.ParentNode.LeftNode = null;
                }
                else
                {
                    node.ParentNode.RightNode = null;
                }
            }
            //нет левого, то правый на место удаляемого 
            else if (node.LeftNode == null)
            {
                if (currentNodeSide == Side.Left)
                {
                    node.ParentNode.LeftNode = node.RightNode;
                }
                else
                {
                    node.ParentNode.RightNode = node.RightNode;
                }

                node.RightNode.ParentNode = node.ParentNode;
            }
            //нет правого, то левый на место удаляемого 
            else if (node.RightNode == null)
            {
                if (currentNodeSide == Side.Left)
                {
                    node.ParentNode.LeftNode = node.LeftNode;
                }
                else
                {
                    node.ParentNode.RightNode = node.LeftNode;
                }

                node.LeftNode.ParentNode = node.ParentNode;
            }
            //если оба присутствуют, 
            //правый на место удаляемого,
            //а левый в правый
            else
            {
                switch (currentNodeSide)
                {
                    case Side.Left:
                        node.ParentNode.LeftNode = node.RightNode;
                        node.RightNode.ParentNode = node.ParentNode;
                        Add(node.LeftNode, node.RightNode);
                        break;
                    case Side.Right:
                        node.ParentNode.RightNode = node.RightNode;
                        node.RightNode.ParentNode = node.ParentNode;
                        Add(node.LeftNode, node.RightNode);
                        break;
                    default:
                        var bufLeft = node.LeftNode;
                        var bufRightLeft = node.RightNode.LeftNode;
                        var bufRightRight = node.RightNode.RightNode;
                        node.Value = node.RightNode.Value;
                        node.RightNode = bufRightRight;
                        node.LeftNode = bufRightLeft;
                        Add(bufLeft, node);
                        break;
                }
            }
        }
    }
}
