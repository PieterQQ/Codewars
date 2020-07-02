using System.Linq;

public static class Kata
{
  public static string[] Capitalize(string s)
  {
    return Enumerable.Range(0, 2).Select(n => string.Concat(s.Select((x, i) => i % 2 == n ? char.ToUpper(x) : x))).ToArray();
  }
}