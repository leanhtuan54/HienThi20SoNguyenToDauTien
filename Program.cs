using System;

namespace HienThi20SoNguyenToDauTien
{
    class Program
    {
        static void Main(string[] args)
        {

            int numbers = 20;

            int count = 0;

            int N = 2;

            while (count < numbers)
            {
                bool isPrime = true;

                if (N <= 1)
                {
                    isPrime = false;
                }
                else
                {
                    for (int i = 2; i <= Math.Sqrt(N); i++)
                    {
                        if (N % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine(N);
                    count++;
                }

                N++;
            }
        }
    }
}