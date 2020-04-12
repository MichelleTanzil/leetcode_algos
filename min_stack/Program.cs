using System;
using System.Collections.Generic;
using System.Linq;

namespace min_stack
{
  public class MinStack
  {

    /** initialize your data structure here. */
    List<int> queue;
    public MinStack()
    {
      queue = new List<int>();
    }

    public void Push(int x)
    {
      queue.Add(x);
    }
    public void Pop()
    {
      queue.RemoveAt(queue.Count - 1);
    }

    public int Top()
    {
      return queue[queue.Count - 1];
    }

    public int GetMin()
    {
      int min = int.MaxValue;
      foreach (int i in queue)
        if (i < min) min = i;
      return min;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      MinStack minStack = new MinStack();
      minStack.Push(-2);
      minStack.Push(0);
      minStack.Push(-3);
      minStack.GetMin();
      minStack.Pop();
      minStack.Top();
      minStack.GetMin();
    }
  }
}
