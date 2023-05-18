
using treebin;
public partial class Program
{
    public static void Main(string[] args)
    {
        BinarySearchTree bst = new BinarySearchTree();
        bst.Insert(4);
        bst.Insert(7);
        bst.Insert(3);
        bst.Insert(5);
        bst.Insert(2);
        bst.Insert(8);
        bst.Insert(1);

        Console.WriteLine("Inorder Traversal:");
        bst.InorderTraversal(bst.Root);
        Console.WriteLine();

        Console.WriteLine("Preorder Traversal:");
        bst.PreorderTraversal(bst.Root);
        Console.WriteLine();

        Console.WriteLine("Postorder Traversal:");
        bst.PostorderTraversal(bst.Root);
        Console.WriteLine();
    }
}