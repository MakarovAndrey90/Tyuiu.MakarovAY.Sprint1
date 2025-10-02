using Tyuiu.MakarovAY.Sprint1.Task6.V13.Lib;
namespace Tyuiu.MakarovAY.Sprint1.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string strTest = "abcd";
            DataService ds = new DataService();
            Assert.AreEqual(true, ds.CheckWordsAlphabet(strTest));
        }
    }
}