using System;

namespace ShortestWord
{
  /*
   * Simple, given a string of words, return the length of the shortest word(s).
   * String will never be empty and you do not need to account for different data types.
   */
  public class Kata
  {
    static char SPACE = ' ';

    static int CompareStringsBySize(string lhs, string rhs)
    {
      return lhs.Length.CompareTo(rhs.Length);
    }

    public static int FindShort(string s)
    {
      var separators = new char[] { SPACE };
      var words = s.Split(separators);
      Array.Sort(words, CompareStringsBySize);
      return words[0].Length;
    }
  }
}
