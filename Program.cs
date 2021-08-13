#nullable enable
using System;

namespace TreeProcessing_Stripped
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate the BST tree.  For which BstInsert() needs to be completed.
            var bst = Tree.Insert6Node();
            
            // Use ToString() to write the tree such that each subtree is (node subSubTree subSubTree)
            Console.WriteLine("6 node tree");
            Console.WriteLine(bst.ToString());

            // Write the mirror of the tree
            Console.WriteLine();
            Console.WriteLine("Mirror of original tree");
            var mirror = bst.Mirror();
            Console.WriteLine(mirror.ToString());

            // Make sure that mirror is now identical to bst (we flipped the subTrees in place
            Console.WriteLine();
            Console.WriteLine("IsSameTree mirror and bst");
            var isSame = Tree.IsSameTree(bst, mirror);
            Console.WriteLine($"Tree.IsSameTree(bst, mirror) = {isSame}.  Expected result: True");

            // Mirror the mirror such that we leave the original mirror untouched
            Console.WriteLine();
            Console.WriteLine("Mirror the mirrored tree.  Generate a new tree");
            var orig = mirror.MirrorNewTree();
            Console.WriteLine(orig.ToString());
            isSame = Tree.IsSameTree(bst, orig);
            Console.WriteLine($"Tree.IsSameTree(bst, orig) = {isSame}.  Expected result: false");

            // Double Tree
            Console.WriteLine();
            Console.WriteLine("Double each node");
            orig.DoubleTree();
            Console.WriteLine(orig.ToString());

            // Is Binary Search Tree
            Console.WriteLine();
            Console.WriteLine("Is Binary Search Tree");
            var isBst = bst.IsBinarySearchTree();
            Console.WriteLine($"bst.IsBinarySearchTree(): {isBst}.  Expected: false");
            isBst = mirror.IsBinarySearchTree();
            Console.WriteLine($"mirror.IsBinarySearchTree(): {isBst}.  Expected: false");
            isBst = orig.IsBinarySearchTree();
            Console.WriteLine($"orig.IsBinarySearchTree(): {isBst}.  Expected: true");
        }
    }

    public class Tree
    {
        /// <summary>
        /// Left subTree
        /// In a BST (Binary Search Tree) scenario, every node's data (in the Left subTree)
        /// is less than or equal to the subTree's root node's data.
        /// </summary>
        public Tree? Left { get; set; }

        /// <summary>
        /// Right subTree
        /// In a BST (Binary Search Tree) scenario, every node's data (in the Right subTree)
        /// is greater than the subTree's root node's data.
        /// </summary>
        public Tree? Right { get; set; }

        /// <summary>
        /// Node's data.  In out case it is an int where less-than, equals and greater-than
        /// are simple to assess.  Otherwise, in order to achieve a BST, we would need to
        /// to employ at least one of the interfaces: IComparable<T> and IComparer<T>
        /// </summary>
        public int Node { get; private set; }

        public Tree(int node)
        {
            Node = node;
            Left = null;
            Right = null;
        }

        /*
        * Insert nodes into the Tree such that if the new node's value <= current 
        * then insert new Node into LEFT subtree Else it belongs to the Right subtree
        *
        *	First node's data, say 100, makes the root.
        *	Second node's data, say 248, therefore it belongs to root's right subtree.
        *          100
        *             \
        *             248
        *
        *	3rd node's data, say 76, makes the left subtree.  Tree now is:
        *          100
        *         /   \
        *       76     248
        *
        *	4th node's data, say 74, is < root, therefore it belongs to the left subtree
        *	it is less than 76 therefore, it belongs to the left of the sub-subTree.
        *  Tree looks like:
        *          100
        *         /   \
        *       76     248
        *      /
        *    74
        *
        * Next node is 178
        * Greater than 100 -- Right subTree
        * Less than 248 -- Left subTree
        * Tree looks like:
        *          100
        *         /   \
        *       76     248
        *      /      /
        *    74     178
        *
        * Next node is 278, which is > 100 and > than 248, Tree looks now like:
        * Tree looks like:
        *          100
        *         /   \
        *       76    248
        *      /     /   \
        *    74    178   278
        *
        * Write a routine that implements the above explanation
        */
        public void BstInsert(int node)
        {
        }

        /*
        * Write a ToString() that will return a string containing the tree structure in paretheses.
        * For example tree:
        *       2
        *      / \
        *     1   3
        * Will be presented as: (2 (1 E E) (3 E E))
        */
        public override string ToString()
        {
            // Placeholder
            return string.Empty;
        }
        
        /*
        * Write a routine that takes a tree and returns the tree's mirror image.
        * Whatever was left subtree becomes right subtree and visa versa.
        *
        * It is easier to flip right/left in place as opposed to returning a brand new tree.
        */
        public Tree Mirror()
        {
            // Placeholder
            return new Tree(0);
        }

        /*
        * Return a new tree that is a mirror of the old tree
        */
        public Tree MirrorNewTree()
        {
            // Placeholder
            return new Tree(0);
        }

        /*
        * Compares a given tree to another tree to
        * see if they are structurally identical.
        */
        public static bool IsSameTree(Tree? lhs, Tree? rhs)
        {
            // Placeholder
            return true;
        }

        /*
        * Changes the tree by inserting a duplicate node
        * on each nodes's left branch.
        * 
        * So the tree...
        *    2
        *   / \
        *  1   3
        *
        * Is changed to...
        *       2
        *      / \
        *     2   3
        *    /   /
        *   1   3
        *  /
        * 1
        *
        * Uses a recursive helper to recur over the tree
        * and insert the duplicates.
        */
        /// <summary>
        /// DoubleTree will turn the original tree into:
        ///               100
        ///              /    \
        ///            100     248
        ///            /       / \
        ///           76     248  \
        ///          /       /     \
        ///         76     178      \
        ///        /       /         \
        ///       74     178          \
        ///      /                   278
        ///     74                   /
        ///                        278
        /// </summary>
        public void DoubleTree()
        {
            
        }

        /// <summary>
        /// Make sure that each node is greater than or equal 
        /// to all left subnodes and less than all right subnodes
        /// 
        /// Assumption: no tree node is less than int.MinValue or greater than int.MaxValue
        /// </summary>
        public bool IsBinarySearchTree()
        {
            // Placeholder
            return true;
        }

        /// <summary>
        ///               100
        ///              /    \
        ///             /      248
        ///            76      / \
        ///           /       /   \
        ///          74      /     \
        ///                178      \
        ///                          278
        /// </summary>
        public static Tree Insert6Node()
        {
            var bstRoot = new Tree(100);
            bstRoot.BstInsert(248);
            bstRoot.BstInsert(76);
            bstRoot.BstInsert(74);
            bstRoot.BstInsert(178);
            bstRoot.BstInsert(278);
            return bstRoot;
        }
    }
}
