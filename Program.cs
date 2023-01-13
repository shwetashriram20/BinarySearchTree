using BinarySearchTrees;

namespace BinarySearchTrees
{
    class Program
    {
        public static void Main(string[] args)
        {
            Binarytree bn = new Binarytree();
            bn.Add(56);
            bn.Add(30);
            bn.Add(70);
            bn.Add(22);
            bn.Add(40);
            bn.Add(3);
            bn.Add(11);
            bn.Add(16);
            bn.Add(60);
            bn.Add(65);
            bn.Add(63);
            bn.Add(67);
            bn.Add(95);
            bn.Add(70);

            Console.WriteLine();
            Console.WriteLine("the preorder is: ");
            bn.TravesrePreorder(bn.root);
            Console.WriteLine();
            Console.WriteLine("the postorder is: ");
            bn.TravesrePostorder(bn.root);
            Console.WriteLine();
            Console.WriteLine("the Inorder is: ");
            bn.TravesreInorder(bn.root);
            Console.WriteLine();

        }
    }
}



