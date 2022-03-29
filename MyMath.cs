
namespace Lab_2
{
    internal class MyMath
    {
        public static double MyPow(float number, int n)
        {
            double result = 1;

            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    result *= number;
                }
            }

            return result;
        }

        public static float MyAbs(float number)
        {
            if (number < 0)
            {
                number *= -1;
            }

            return number;
        }

        public static float MyRoot(float number, int n, float eps)
        {
            float tempPreviousX = 0F;
            float result = 1F;

            while (MyAbs(result - tempPreviousX) > eps)
            {
                tempPreviousX = result;
                result = (1F / n) * ((n - 1) * tempPreviousX + number / (float)MyPow(tempPreviousX, n - 1));
            }

            return result;
        }
    }
}
