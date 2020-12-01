using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstYask
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int a = 0, b = 1000;
            for (int i = a; i < b; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }

            }
            System.Console.WriteLine("Сумма чисел меньших 1000, которые делятся на 3 или 5: " + sum);
            String str = System.Console.ReadLine();
        }
    }
}
