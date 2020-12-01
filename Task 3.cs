using System;

namespace FirstYask
{
    class Program
    {
        static void Main()
        {

            long num = 600851475143;
            int a = 2;
            while (true) {
                if (num % a == 0)
                {
                    
                    num /= a;
                    if (num == 1)
                    {
                        System.Console.WriteLine("Наибольший делитель простого числа: " + a);
                        break;
                    }
                }
                a += 1;
            }

            String str = System.Console.ReadLine();
        }
    }
}
