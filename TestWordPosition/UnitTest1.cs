using WordsPosition;

namespace TestWordPosition
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("привет 1, морская 3, улиточка 4", Selection.GetPosition("Привет, я - морская улиточка!"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("Привет 1 5, морская 3, улиточка 4", Selection.GetPosition("Привет, я - морская улиточка! Привет!"));
        }
    }
}