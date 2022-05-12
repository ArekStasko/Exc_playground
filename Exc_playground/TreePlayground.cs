using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_playground
{
    internal class Utilities
    {
        public static void Print<T>(BinTreeNode<T> p, int level = 0)
        {
            if (p == null) return;
            Print(p.Right, level + 1);
            Console.WriteLine("".PadLeft(level, '.') + p.Value);
            Print(p.Left, level + 1);
        }

        public static BinTreeNode<char> CreateTreeOfChars()
        {
            return new BinTreeNode<char>('A',
                new BinTreeNode<char>('B', new BinTreeNode<char>('D'), new BinTreeNode<char>('E')),
                new BinTreeNode<char>('C', new BinTreeNode<char>('F',
                new BinTreeNode<char>('H'), new BinTreeNode<char>('I')),
                new BinTreeNode<char>('G')));
        }

        public static void PrintTree<T>(BinTreeNode<T> p, int level = 0)
        {
            if (p == null) return;
            PrintTree(p.Right, level + 1);
            Console.WriteLine("".PadLeft(level, '.') + p.Value);
            PrintTree(p.Left, level + 1);
        }

        public static void DoMirrorOfTree<T>(BinTreeNode<T> tree, int level = 0)
        {
            if (tree == null) return;
            Print(tree.Right, level + 1);
            Console.WriteLine("".PadLeft(level, '.') + tree.Value);
            Print(tree.Left, level + 1);
        }

        public static int NoOfNodes<T>(BinTreeNode<T> tree)
        {
            int nodesCount = 1;             
            if (tree == null)
                return 0;
            else
            {
                nodesCount += NoOfNodes<T>(tree.Left);
                nodesCount += NoOfNodes<T>(tree.Right);
                return nodesCount;
            }
        }

        public static int Depth<T>(BinTreeNode<T> tree)
        {
            if(tree == null) return 0;

            int left = Depth(tree.Left);
            int right = Depth(tree.Right);

            if(left > right) return left +1;
            else return right +1;
        }

        public static void RunTest()
        {
            var tB = new BinTreeNode<char>('B');
            tB.Left = new BinTreeNode<char>('D');
            tB.Right = new BinTreeNode<char>('E');
            var tC = new BinTreeNode<char>('C',
                        new BinTreeNode<char>('F',
                            new BinTreeNode<char>('H'),
                            new BinTreeNode<char>('I')),
                        new BinTreeNode<char>('G')
                     );
            var t = new BinTreeNode<char>('A', tB, tC);
            Print(t);
            Console.WriteLine("--------");
            DoMirrorOfTree(t);
        }
    }


    internal class BinTreeNode<T>
    {
        public T Value { get; set; }
        public BinTreeNode<T> Left { get; set; }
        public BinTreeNode<T> Right { get; set; }

        public BinTreeNode(T value, BinTreeNode<T> left = null, BinTreeNode<T> right = null)
        {
            Value = value;
            Left = left;
            Right = right;
        }


    }
}
