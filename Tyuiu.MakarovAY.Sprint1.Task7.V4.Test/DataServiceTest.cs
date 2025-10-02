using Tyuiu.MakarovAY.Sprint1.Task7.V4.Lib;
namespace Tyuiu.MakarovAY.Sprint1.Task7.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3 ; double y = 2; double wait = -0.354;
            var res = ds.Calculate(x, y);;
            Assert.AreEqual(wait, res);
        }
    }
}