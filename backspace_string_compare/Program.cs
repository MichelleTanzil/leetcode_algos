using System;

namespace backspace_string_compare
{
  class Program
  {
    public static bool BackspaceCompare(string S, string T)
    {
      char[] cOne = S.ToCharArray();
      char[] cTwo = T.ToCharArray();

      int index1, index2;
      index1 = cOne.Length - 1;
      index2 = cTwo.Length - 1;
      while (index1 >= 0 || index2 >= 0)
      {
        index1 = getNextCharIndex(cOne, index1);
        index2 = getNextCharIndex(cTwo, index2);

        // Both are not finished and chars ar different.
        if (index1 >= 0 && index2 >= 0 && cOne[index1] != cTwo[index2])
        {
          return false;
        }

        // one of them has finished but not both.
        if ((index1 < 0 || index2 < 0) && (index1 >= 0 || index2 >= 0))
        {
          return false;
        }

        index1--; index2--;
      }

      return true;
    }

    private static int getNextCharIndex(char[] cOne, int index1)
    {
      int hashCounter = 0;
      while (index1 >= 0)
      {
        if (cOne[index1] == '#')
        {
          hashCounter++;
        }
        else if (hashCounter > 0)
        {
          hashCounter--;
        }
        else
        {
          break;
        }

        index1--;
      }

      return index1;
    }
    static void Main(string[] args)
    {
      Console.WriteLine(BackspaceCompare("ab#c", "ad#c"));
      Console.WriteLine(BackspaceCompare("ab##", "c#d#"));
      Console.WriteLine(BackspaceCompare("a##c", "a#c#"));
      Console.WriteLine(BackspaceCompare("a#c", "b"));
    }
  }
}
