using System;
using System.Collections.Generic;

namespace group_anagrams
{
  class Program
  {
    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
      Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
      foreach (var str in strs)
      {
        var strSort = str.ToCharArray();
        Array.Sort(strSort);
        string strSorted = new string(strSort);
        if (!dict.ContainsKey(strSorted)) dict.Add(strSorted, new List<string>());
        dict[strSorted].Add(str);
      }
      return new List<IList<string>>(dict.Values);
    }
    static void Main(string[] args)
    {
      Console.WriteLine(GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" }));
    }
  }
}
