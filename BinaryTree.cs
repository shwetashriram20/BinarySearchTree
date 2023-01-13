using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTrees
{
    public class Binarytree
    {
        public Node root { get; set; }

        public bool Add(int value)
        {
            Node before = null;
            Node after = this.root;
            while (after != null)
            {
                before = after;
                if (value < after.data)
                {
                    after = after.leftnode;

                }
                else if (value > after.data)
                {
                    after = after.rightnode;
                }
                else return false;
            }
            Node newNode = new Node();
            newNode.data = value;
            if (this.root == null)
            {
                this.root = newNode;
            }
            else
            {
                if (value < before.data)
                {
                    before.leftnode = newNode;
                }
                else
                {
                    before.rightnode = newNode;
                }
            }
            return true;
        }

        public void TravesrePreorder(Node Parent)
        {
            if (Parent != null)
            {
                Console.WriteLine(Parent.data + " ");
                TravesrePreorder(Parent.leftnode);
                TravesrePreorder(Parent.rightnode);
            }


        }
        public void TravesrePostorder(Node Parent)
        {
            Console.WriteLine();
            if (Parent != null)
            {

                TravesrePreorder(Parent.leftnode);
                TravesrePreorder(Parent.rightnode);
                Console.WriteLine(Parent.data + " ");
            }

        }
        public void TravesreInorder(Node Parent)
        {
            Console.WriteLine();
            if (Parent != null)
            {

                TravesrePreorder(Parent.leftnode);
                Console.WriteLine(Parent.data + " ");
                TravesrePreorder(Parent.rightnode);

            }

        }


    }
}


