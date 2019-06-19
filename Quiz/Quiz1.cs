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

        public static void Quiz_2()
        {
            int endNumber = 0, i = 1, maxnum = 4000000;
            while (i != 0)
            {
                if (Pibonachi(i) <= maxnum)
                {
                    if (Pibonachi(i) % 2 == 0)
                    {
                        endNumber += Pibonachi(i);
                        Console.Write("{0}, ", Pibonachi(i));
                    }
                    i++;
                }

                else
                {
                    i = 0;
                }
            }
            Console.WriteLine("\n{0}", endNumber);
        }

        public static int Pibonachi(int num)
        {
            if(num<=2)
            {
                return num;
            }
            else
            {
               return Pibonachi(num - 1) + Pibonachi(num - 2);
            }
            
        }

        public static void Quiz_3()
        {
            long number = 600851475143;
            long max_number = 0;
            int i = 0;
            for (i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    number = number / i;
                    Console.WriteLine(" {0}, ", i);
                    max_number = i;
                }
            }
            Console.WriteLine("MAX Number : {0}", max_number);
        }

        public static void Quiz_4()
        {
            int count = 0;
            int number = 1;
            while (count < 20)
            {
                if (count == 19)
                {
                    break;
                }
                else
                {
                    count = 0;
                    number++;
                    for (int i = 1; i <= 20; i++)
                    {
                        if (number % i == 0)
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine("{0}", number);
        }

    }
}
