using System.Text;

public class Carboat
{
    public static string howmuch(int m, int n)
    {
        if(m > n) return howmuch(n, m);
        var result = new StringBuilder("[");
        for(int i = m; i <= n; i++)
        {
            double b = (i - 2) / 7f;
            double c = (i - 1) / 9f;
            if(b % 1 == 0 && c % 1 == 0)
                result.AppendFormat("[M: {0} B: {1} C: {2}]", i, b, c);
        }
        result.Append(']');
        return result.ToString();
    }
}