using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Binarysearchtree<int> binarySearchTree = new Binarysearchtree<int>(56);
            binarySearchTree.Insert(30);
            binarySearchTree.Insert(70);
            binarySearchTree.Insert(22);
            binarySearchTree.Insert(40);
            binarySearchTree.Insert(60);
            binarySearchTree.Insert(95);
            binarySearchTree.Insert(11);
            binarySearchTree.Insert(65);
            binarySearchTree.Insert(3);
            binarySearchTree.Insert(16);
            binarySearchTree.Insert(63);
            binarySearchTree.Insert(67);
            Console.WriteLine("Binary Search Tree -");
            binarySearchTree.Display();
            binarySearchTree.Size();
            bool findElement = binarySearchTree.ifExists(63, binarySearchTree);
            Console.ReadLine();
        }
    }
}
