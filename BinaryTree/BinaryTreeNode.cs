namespace BinaryTree
{
    public enum Side
    {
        Left,
        Right
    }

    public class BinaryTreeNode<T> where T : IComparable
    {
        public BinaryTreeNode(T value)
        {
            Value = value;
        }
        public BinaryTreeNode<T> LeftNode { get; set; }
        public BinaryTreeNode<T> RightNode { get; set; }
        public BinaryTreeNode<T> ParentNode { get; set; }

        public T Value { get; set; }

        public Side? GetSide =>
            ParentNode == null ? null
            : ParentNode.LeftNode == this
                ? Side.Left
                : Side.Right;

        public override string ToString() => Value.ToString();
    }
}
