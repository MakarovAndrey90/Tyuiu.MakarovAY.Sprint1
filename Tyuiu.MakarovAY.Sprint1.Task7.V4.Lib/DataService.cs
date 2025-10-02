using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MakarovAY.Sprint1.Task7.V4.Lib
{
    public class DataService : ISprint1Task7V4
    {
        public double Calculate(double x, double y)
        {   
            double res = Math.Round(Math.Log(Math.Abs((y - Math.Abs(Math.Sqrt(x))) * (x - y / (x + Math.Pow(x, 2) / 4)))), 3);
            return res;
        }
    }
}
