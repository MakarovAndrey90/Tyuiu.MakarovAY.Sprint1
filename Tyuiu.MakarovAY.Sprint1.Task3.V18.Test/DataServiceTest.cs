using Tyuiu.MakarovAY.Sprint1.Task3.V18.Lib;
namespace Tyuiu.MakarovAY.Sprint1.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 2;
            double b = 3;
            double c = 1;
            double wait = 6;
            var res = ds.HowManySquares(a, b, c);
            Assert.AreEqual(wait, res);
        }
    }
} 
