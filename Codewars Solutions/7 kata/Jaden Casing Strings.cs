using System.Globalization;
using System;
public static class JadenCase
{
  public static string ToJadenCase(this string phrase)
  {
  
    return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
  }
}