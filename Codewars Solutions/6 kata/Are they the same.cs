using System;
using System.Linq;

class AreTheySame
{
  public static bool comp(int[] a, int[] b)
  {
    if ((a == null) || (b == null)){
      return false;
    }

    int[] copy = a.Select(x => x * x).ToArray();
    Array.Sort(copy);
    Array.Sort(b);

    return copy.SequenceEqual(b);
  }
}