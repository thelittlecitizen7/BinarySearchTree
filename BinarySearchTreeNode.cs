
using System.ComponentModel.DataAnnotations;

namespace BinarySearchTree
{
    public class BSTNode
    {
        public BSTNode(int value)
        {
            Value = value;
        }

        public int Value { get; private set; }

        public BSTNode Left { get; set; }

        public BSTNode Right { get; set; }

        public int Min()
        {
            if (Left != null)
            {
                return Left.Min();
            }
            return Value;
        }



        public int Max()
        {
            if (Right != null)
            {
                return Right.Max();
            }
            return Value;
        }


        public bool AddItem(int value)
        {
            if (Value < value)
            {
                if (Right == null)
                {
                    Right = new BSTNode(value);
                    return true;
                }
                else
                {
                    return Right.AddItem(value);
                }
            }
            else if (Value > value)
            {
                if (Left == null)
                {
                    Left = new BSTNode(value);
                    return true;
                }
                else
                {
                    return Left.AddItem(value);
                }
            }
            else
            {
                return false;
            }
        }


        public bool Contains(int value)
        {
            if (Value == value)
            {
                return true;
            }
            BSTNode startNode = null;
            if (Right.Value > value)
            {
                startNode = Right;
            }
            else
            {
                startNode = Left;
            }
            BSTNode node = FindByRecursive(startNode, value);
            return (node != null);
        }



        public BSTNode FindItem(int value)
        {
            if (Value == value)
            {
                return this;
            }
            BSTNode startNode = null;
            if (Right != null)
            {
                if (value >= Value)
                {
                    startNode = Right;
                }

            }
            if (Left != null)
            {
                if (value <= Left.Value)
                {
                    startNode = Left;
                }
            }
            BSTNode node = FindByRecursive(startNode, value);
            return node;
        }

        private BSTNode FindByRecursive(BSTNode node, int value)
        {

            if (node == null)
            {
                return null;
            }
            if (node.Value == value)
            {
                return node;
            }
            if (node.Value > value)
            {
                node = node.Left;
            }
            else
            {
                node = node.Right;
            }
            return FindByRecursive(node, value);
        }

        private BSTNode FindFatherOfNode(BSTNode father, BSTNode child, int value)
        {
            if (child == null)
            {
                return father;
            }

            if (value < father.Value)
            {
                if (father.Left.Value == value)
                {
                    return father;
                }
                father = father.Left;
                child = child.Left;
                return FindFatherOfNode(father, child, value);
            }
            else if (value > father.Value)
            {
                if (father.Right.Value == value)
                {
                    return father;
                }
                father = father.Right;
                child = child.Right;
                return FindFatherOfNode(father, child, value);
            }
            else
            {
                return father;
            }

        }

        public bool DeleteItem(int value, BSTNode parent)
        {
            if (parent != null)
            {
                var node = FindItem(value);
                if (node == null)
                {
                    return false;
                }
                var father = FindFatherOfNode(parent, node, value);
                if (father != null)
                {
                    bool isSuccedd = false;
                    if (node.Left != null)
                    {
                        father.Left = node.Left;
                        isSuccedd = true;
                    }
                    else
                    {
                            father.Left = null;
                            isSuccedd = true;
                        
                    }
                    if (node.Right != null)
                    {
                        father.Right = node.Right;
                        isSuccedd = true;
                    }
                    else 
                    {
                        father.Right = null;
                        isSuccedd = true;
                    }
                    

                return isSuccedd;
            }
            else
            {
                return false;
            }
        }
            return false;
            
        }
}
}
