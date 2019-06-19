using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public static partial class Quizes
    {
        public static void Quiz_1()
        {
            int[] number = new int[1000];
            int j = 0, k = 0;
            for (int i = 1; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    number[j] = i;
                    j++;
                }
            }
            for (int i = 0; i < j; i++)
            {
                k = number[i] + k;
            }
            Console.Write("1~1000사이의 3과 5 배수 합 : ");
            Console.WriteLine(k);
        }
    }
}
