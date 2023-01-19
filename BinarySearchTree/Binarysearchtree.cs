using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class Binarysearchtree<T> where T : IComparable
    {
        T NodeData;
        public Binarysearchtree<T> leftTree { get; set; }
        public Binarysearchtree<T> rightTree { get; set; }
        bool result = false;
        int leftCount = 0;
        int rightCount = 0;

        public Binarysearchtree(T NodeData)
        {
            this.NodeData = NodeData;
            this.leftTree = null;
            this.rightTree = null;
        }
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                    this.leftTree = new Binarysearchtree<T>(item);
                else
                    this.leftTree.Insert(item);
            }
            else
            {
                if (this.rightTree == null)
                    this.rightTree = new Binarysearchtree<T>(item);
                else
                    this.rightTree.Insert(item);
            }
        }
        public void Display()
        {
            if (this.leftTree != null)
            {
                this.leftCount++;
                this.leftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.rightTree != null)
            {
                this.rightCount++;
                this.rightTree.Display();
            }

        }
        public void Size()
        {
            Console.WriteLine("Size of Binary Serach Tree " + (1 + leftCount + rightCount));
        }
        public bool ifExists(T element, Binarysearchtree<T> node)
        {
            if (node == null)
                return false;
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Found element in Binary Search Tree " + node.NodeData);
                return true;
            }
            else

                Console.WriteLine("Current element is {0} in BST ", node.NodeData);
            if (element.CompareTo(node.NodeData) < 0)
                ifExists(element, node.leftTree);
            if (element.CompareTo(node.NodeData) > 0)
                ifExists(element, node.rightTree);
            return result;
        }
    }
}
