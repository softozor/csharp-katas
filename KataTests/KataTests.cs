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
  }
}
