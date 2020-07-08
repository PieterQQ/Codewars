using System.Linq;

public class Kata
{
  public static int Find(int[] integers)
  {
    var evenNumbers = integers.Where(integer => integer % 2 == 0);
    var oddNumbers = integers.Where(integer => integer % 2 == 1);
    return evenNumbers.Count() == 1 ? evenNumbers.First() : oddNumbers.First();
  }
}