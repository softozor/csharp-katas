using Microsoft.VisualStudio.TestTools.UnitTesting;
using Katas;

namespace KataTests
{
  [TestClass]
  public class KataTests
  {
    [TestMethod]
    public void ShortestWordTests()
    {
      Assert.AreEqual(3, ShortestWord.FindShort("bitcoin take over the world maybe who knows perhaps"));
      Assert.AreEqual(3, ShortestWord.FindShort("turns out random test cases are easier than writing out basic ones"));
    }

    [TestMethod]
    public void DuplicateCountTests()
    {
      Assert.AreEqual(0, CountingDuplicates.DuplicateCount(""));
      Assert.AreEqual(0, CountingDuplicates.DuplicateCount("abcde"));
      Assert.AreEqual(2, CountingDuplicates.DuplicateCount("aabbcde"));
      Assert.AreEqual(2, CountingDuplicates.DuplicateCount("aabBcde"), "should ignore case");
      Assert.AreEqual(1, CountingDuplicates.DuplicateCount("Indivisibility"));
      Assert.AreEqual(2, CountingDuplicates.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
    }
  }
}
