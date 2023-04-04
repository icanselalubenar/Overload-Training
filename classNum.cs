using System;
namespace Overload
{
    public class classNum
    {
        public int cariNilaiMin(int a, int b, int c)
        {
            int min = 0;
            if (a < b && a < c)
                Console.WriteLine("Nilai minimum dari ketiga nilai adalah = {0}", min = a);
            else if (b < a && b < c)
                Console.WriteLine("Nilai minimum dari ketiga nilai adalah = {0}", min = b);
            else if (c < a && c < b)
                Console.WriteLine("Nilai minimum dari ketiga nilai adalah = {0}", min = c);

            return min;
        }
        public int cariNilaiMax(int a, int b, int c)
        {
            int max = 0;
            if (a > b && a > c)
                Console.WriteLine("Nilai maksimum dari ketiga nilai adalah = {0}", max = a);
            else if (b > a && b > c)
                Console.WriteLine("Nilai maksimum dari ketiga nilai adalah = {0}", max = b);
            else if (c > a && c > b)
                Console.WriteLine("Nilai maksimum dari ketiga nilai adalah = {0}", max = c);

            return max;
        }
    }
}

