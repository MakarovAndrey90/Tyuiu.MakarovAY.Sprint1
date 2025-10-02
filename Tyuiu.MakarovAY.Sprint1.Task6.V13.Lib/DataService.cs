using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MakarovAY.Sprint1.Task6.V13.Lib
{
    public class DataService : ISprint1Task6V13
    {
        public bool CheckWordsAlphabet(string value)
        {
            bool x = true;
            for (int i = 0; i < value.Length - 1; ++i)
            {
                if (value[i] > value[i + 1])
                {
                    x = false;
                    break;
                }

            }
            return x;

        }
    }
}
