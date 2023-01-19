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
            Console.WriteLine("Binary Search Tree -");
            binarySearchTree.Display();
            Console.ReadLine();
        }
    }
}
