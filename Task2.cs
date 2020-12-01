using System;

namespace FirstYask
{
    class Program
    {
        static void Main()
        {

            int sum = 0;
            int a = 1, b = 2;
            int temp;
            while (b < 4000000)
            {
                if (b % 2 == 0)
                {
                    sum += b;
                    
                }

                temp = b;
                b = a + b;
                a = temp;

            }
            System.Console.WriteLine("Сумма четных чисел Фиббоначи: " + sum);
            String str = System.Console.ReadLine();
        }
    }
}
