using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTree
{
    public class Tree<Titem> : IBinaryTree<Titem>
        where Titem : IComparable<Titem>
    {
        public Titem NodeData { get; set; }
        public Tree<Titem> LeftTree { get; set; }
        public Tree<Titem> RightTree { get; set; }

        public Tree(Titem nodeValue)
        {
            this.NodeData = nodeValue;
            this.LeftTree = null;
            this.RightTree = null;
        }

        public void Add(Titem newItem)
        {
            Titem currentNodeValue = this.NodeData;
            if (currentNodeValue.CompareTo(newItem) > 0)
            {
                if (this.LeftTree == null)
                {
                    this.LeftTree = new Tree<Titem>(newItem);
                }
                else 
                {
                    this.LeftTree.Add(newItem);
                }
            }
            else 
            {
                if (this.RightTree == null)
                {
                    this.RightTree = new Tree<Titem>(newItem);
                }
                else
                {
                    this.RightTree.Add(newItem);
                }
            }
        }

        /// <summary>
        /// Removes an item from the tree.
        /// <para>
        /// Note that you cannot remove the last node from the tree.
        /// </para>
        /// <para>
        /// If the item is not found in the tree, nothing happens.
        /// </para>
        /// <para>
        /// The remove algorithm needs to treat removing the root node differently from other
        /// nodes - if the root node has no children it can't be removed.
        /// </para>
        /// <para>
        /// In general remove has to deal with 3 scenarios - nodes with no children,
        /// nodes with a single child, and nodes with two children.
        /// </para>
        /// </summary>
        /// <param name="itemToRemove"></param>
        public void Remove(Titem itemToRemove)
        {

            // Cannot remove null.
            if (itemToRemove == null)
            {
                return;
            }

            // Check if the item could be in the left tree.
            if (this.NodeData.CompareTo(itemToRemove) > 0 && this.LeftTree != null)
            {
                // Check the left tree.
                // Check 2 levels down the tree - cannot remove
                // 'this', only the LeftTree or RightTree properties.
                if (this.LeftTree.NodeData.CompareTo(itemToRemove) == 0)
                {
                    // The LeftTree property has no children - set the LeftTree property to null.
                    if (this.LeftTree.LeftTree == null && this.LeftTree.RightTree == null)
                    {
                        this.LeftTree = null;
                    }
                    else // Remove the LeftTree property.
                    {
                        RemoveNodeWithChildren(this.LeftTree);
                    }
                }
                else
                {
                    // Keep looking - call Remove recursively.
                    this.LeftTree.Remove(itemToRemove);
                }
            }

            // Check if the item could be in the right tree. 
            if (this.NodeData.CompareTo(itemToRemove) < 0 && this.RightTree != null)
            {
                // Check the right tree.
                // Check 2 levels down the tree - cannot remove
                // 'this', only the LeftTree or RightTree properties.
                if (this.RightTree.NodeData.CompareTo(itemToRemove) == 0)
                {
                    // RightTree has no children - set RightTree to null.
                    if (this.RightTree.LeftTree == null && this.RightTree.RightTree == null)
                    {
                        this.RightTree = null;
                    }
                    else // Remove the RightTree property.
                    {
                        RemoveNodeWithChildren(this.RightTree);
                    }
                }
                else
                {
                    // Keep looking - call Remove recursively.
                    this.RightTree.Remove(itemToRemove);
                }
            }

            // This will only apply at the root node.
            if (this.NodeData.CompareTo(itemToRemove) == 0)
            {
                // No children - do nothing, a tree must have at least one node.               
                if (this.LeftTree == null && this.RightTree == null)
                {
                    return;
                }
                else // Root node has children.
                {
                    RemoveNodeWithChildren(this);
                }
            }
        }

        /// <summary>
        /// Utility method used by the Remove method.
        /// <para>
        /// It removes a node that has either one or two children.
        /// </para>
        /// </summary>
        /// <param name="node"></param>
        private void RemoveNodeWithChildren(Tree<Titem> node)
        {
            // Check whether the node has children.
            if (node.LeftTree == null && node.RightTree == null)
            {
                throw new ArgumentException("Node has no children");
            }

            // The tree node has only one child - replace the tree node with its child node.
            if (node.LeftTree == null ^ node.RightTree == null)
            {
                if (node.LeftTree == null)
                {
                    node.CopyNodeToThis(node.RightTree);
                }
                else
                {
                    node.CopyNodeToThis(node.LeftTree);
                }
            }
            else
            // The tree node has two children - replace the tree node's value with its "in order successor" node value
            // and then remove the in order successor node.
            {
                // Find the in order successor - left most descendant of its RightTree property.
                Tree<Titem> successor = GetLeftMostDescendant(node.RightTree);

                // Copy the node value from the in order successor.
                node.NodeData = successor.NodeData;

                // Remove the in order successor node.
                if (node.RightTree.RightTree == null && node.RightTree.LeftTree == null)
                {
                    node.RightTree = null; // The successor node had no children.
                }
                else
                {
                    node.RightTree.Remove(successor.NodeData);
                }
            }
        }

        /// <summary>
        /// Utility method to copy values from another tree node to this node.
        /// </summary>
        /// <param name="node">Tree node to copy from.</param>
        private void CopyNodeToThis(Tree<Titem> node)
        {
            this.NodeData = node.NodeData;
            this.LeftTree = node.LeftTree;
            this.RightTree = node.RightTree;
        }

        /// <summary>
        /// Utility method to find the left most descendant of a tree node.
        /// </summary>
        /// <param name="node">Tree node to start from.</param>
        /// <returns>Left most descendant.</returns>
        private Tree<Titem> GetLeftMostDescendant(Tree<Titem> node)
        {
            while (node.LeftTree != null)
            {
                node = node.LeftTree;
            }
            return node;
        }

        public void WalkTree()
        {
            if (this.LeftTree != null)
            {
                this.LeftTree.WalkTree();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
                this.RightTree.WalkTree();
            }
        }
    }
}
