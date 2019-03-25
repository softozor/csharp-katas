using System.Linq;

namespace Katas
{
  public class CountingDuplicates
  {
    /*
     * Write a function that will return the count of distinct
     * case-insensitive alphabetic characters and numeric digits
     * that occur more than once in the input string. The input
     * string can be assumed to contain only alphabets (both
     * uppercase and lowercase) and numeric digits.
     */
    public static int DuplicateCount(string str)
    {
      // a better solution is possible like this:
      // return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();
      var lowerCaseStr = str.ToLower();
      return lowerCaseStr
        .Distinct()
        .Where(distinctChar => lowerCaseStr.Count(currChar => currChar == distinctChar) > 1)
        .Count();
    }
  }
}
