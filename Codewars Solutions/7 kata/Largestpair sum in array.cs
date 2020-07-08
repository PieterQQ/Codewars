using System.Linq;
public class Kata
{
  public static int LargestPairSum(int[] numbers)
     => numbers.OrderByDescending(x=>x).Take(2).Sum();
}