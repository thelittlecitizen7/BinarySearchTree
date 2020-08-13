using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Xml.Schema;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        public BSTNode Root { get; set; }

        public BinarySearchTree()
        {
            Root = null;
        }

        public BinarySearchTree(int value)
        {
            Root = new BSTNode(value);
        }

        public BinarySearchTree(BSTNode root)
        {
            Root = root;
        }

        public int GetMax()
        {
            return Root.Max();
        }

        public int GetMin()
        {
            return Root.Min();
        }

        public bool AddItem(int value)
        {
            return Root.AddItem(value);
        }

        public bool Contains(int value)
        {
            return FindItem(value) != null;
        }

        public BSTNode FindItem(int value)
        {
            if (Root == null)
            {
                return null;
            }
            return Root.FindItem(value);
        }

        public bool DeleteItem(int value)
        {
            if (Root == null)
            {
                return false;
            }
            return Root.DeleteItem(value, Root);
        }

        private void OrderBst()
        {
            throw new System.NotImplementedException();
        }

        private BSTNode SortedArrayToBST(int[] array, int start, int end)
        {
            throw new System.NotImplementedException();
        }

        private IEnumerable<int> Scan(BSTNode node)
        {
            throw new System.NotImplementedException();
        }
    }
}
