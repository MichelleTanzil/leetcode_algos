using System;

namespace diameter_of_binary_tree
{
  /**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
  class Program
  {
    private int diameter;

    public int DiameterOfBinaryTree(TreeNode root)
    {
      diameter = 0;
      FindDiameter(root);
      return diameter;
    }
    private int FindDiameter(TreeNode root)
    {
      if (root == null) return 0;
      int right = FindDiameter(root.right);
      int left = FindDiameter(root.left);
      diameter = Math.Max(diameter, left + right);
      return Math.Max(left, right) + 1;
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}
