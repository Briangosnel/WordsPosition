using WordsPosition;

namespace TestWordPosition
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("������ 1, ������� 3, �������� 4", Selection.GetPosition("������, � - ������� ��������!"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("������ 1 5, ������� 3, �������� 4", Selection.GetPosition("������, � - ������� ��������! ������!"));
        }
    }
}