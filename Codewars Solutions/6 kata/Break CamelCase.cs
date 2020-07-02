using System;
using System.Linq;
public class Kata
{
  public static string BreakCamelCase(string str)
  {
        return str = string.Concat(str.Select(x => Char.IsUpper(x) ? " " + x : x.ToString())).TrimStart(' ');
                
  }
}