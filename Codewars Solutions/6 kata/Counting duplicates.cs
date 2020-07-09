using System.Linq;

public class Kata
{
  public static int DuplicateCount(string str)
  {
    return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();
  }
}