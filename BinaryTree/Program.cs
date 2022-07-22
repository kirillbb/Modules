namespace BinaryTree
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var binaryTree = new BinaryTree<Int32>();
            binaryTree.Add(0);
            binaryTree.Add(6);
            binaryTree.Add(12);
            binaryTree.Add(13);
            binaryTree.Add(5);
            binaryTree.Add(2);
            binaryTree.Add(1);
            binaryTree.Add(20);
            binaryTree.Add(8);
            binaryTree.Add(3);

            binaryTree.Print();

            var binaryStringTree = new BinaryTree<String>();
            binaryStringTree.Add("Hello");
            binaryStringTree.Add("how");
            binaryStringTree.Add("r");
            binaryStringTree.Add("you");
            binaryStringTree.Add("?");
            binaryStringTree.Add("bye");

            binaryStringTree.Print();

            binaryTree.Remove(8);
            binaryTree.Remove(20);

            binaryTree.Print();

            Console.WriteLine();
        }
    }
}
