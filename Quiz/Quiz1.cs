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
            //122 522 40/ 232 792 560
            int count = 0;
            int number = 1;
            while (count <= 20)
            {
                if (count == 20)
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

        public static void Quiz_5()
        {
            int[] minority = new int[10001];

            int count = 0, num = 1, minorityNumber = 0;
            while(minorityNumber<10001)
            {
                count = 0;
                for (int i = 1;i<=num;i++)
                {
                    if(num%i==0)
                    {
                        count++;
                    }
                }
                if(count==2)
                {
                    minority[minorityNumber] = num;
                    minorityNumber++;
                }
                num++;
            }
            Console.WriteLine("{0}번째 소수 : {1},", minorityNumber, minority[minorityNumber - 1]);
        }

        public static void Quiz_6()
        {
            int[,] map = new int[20,20] { { 08,02,22,97,38,15,00,40,00,75,04,05,07,78,52,12,50,77,91,08 },
                   { 49,49,99,40,17,81,18,57,60,87,17,40,98,43,69,48,04,56,62,00 },
                   { 81,49,31,73,55,79,14,29,93,71,40,67,53,88,30,03,49,13,36,65 },
                   { 52,70,95,23,04,60,11,42,69,24,68,56,01,32,56,71,37,02,36,91 },
                   { 22,31,16,71,51,67,63,89,41,92,36,54,22,40,40,28,66,33,13,80 },
                   { 24,47,32,60,99,03,45,02,44,75,33,53,78,36,84,20,35,17,12,50 },
                   { 32,98,81,28,64,23,67,10,26,38,40,67,59,54,70,66,18,38,64,70 },
                   { 67,26,20,68,02,62,12,20,95,63,94,39,63,08,40,91,66,49,94,21 },
                   { 24,55,58,05,66,73,99,26,97,17,78,78,96,83,14,88,34,89,63,72 },
                   { 21,36,23,09,75,00,76,44,20,45,35,14,00,61,33,97,34,31,33,95 },
                   { 78,17,53,28,22,75,31,67,15,94,03,80,04,62,16,14,09,53,56,92 },
                   { 16,39,05,42,96,35,31,47,55,58,88,24,00,17,54,24,36,29,85,57 },
                   { 86,56,00,48,35,71,89,07,05,44,44,37,44,60,21,58,51,54,17,58 },
                   { 19,80,81,68,05,94,47,69,28,73,92,13,86,52,17,77,04,89,55,40 },
                   { 04,52,08,83,97,35,99,16,07,97,57,32,16,26,26,79,33,27,98,66 },
                   { 88,36,68,87,57,62,20,72,03,46,33,67,46,55,12,32,63,93,53,69 },
                   { 04,42,16,73,38,25,39,11,24,94,72,18,08,46,29,32,40,62,76,36 },
                   { 20,69,36,41,72,30,23,88,34,62,99,69,82,67,59,85,74,04,36,16 },
                   { 20,73,35,29,78,31,90,01,74,31,49,71,48,86,81,16,23,57,05,54 },
                   { 01,70,54,71,83,51,54,69,16,92,33,48,61,43,52,01,89,19,67,48 }
            };
            int[] max = new int[4];
            int lastMax = 0;
            max[0] = Horizon(map);
            max[1] = VertiCality(map);
            max[2] = Left_Up(map);
            max[3] = Right_Up(map);

            lastMax = max[0];
            for (int i = 0; i < 4; i++)
            {
                if(lastMax <= max[i])
                {
                    lastMax = max[i];
                }
            }
            Console.WriteLine("가장 큰 수 = {0}", lastMax);

        }

        public static int Horizon(int[,] map)
        {
            int number = 1;
            int[] mulNumber = new int[1000];
            int num = 0, max = 0;
            for(int i=0;i<20;i++)
            {
                for(int j=0;j<17;j++)
                {
                    for(int z=j;z<j+4;z++)
                    {
                        number *= map[i, z];
                    }
                    mulNumber[num] = number;
                    number = 1;
                    num++;
                }
            }
            max = mulNumber[0];
            for(int i=0;i<num;i++)
            {
                if (max <= mulNumber[i])
                {
                    max = mulNumber[i];
                }
            }
            return max;
        }

        public static int VertiCality(int[,] map)
        {
            int number = 1, num = 0, max = 0;
            int[] mulNumber = new int[1000];
            for(int j=0;j<20;j++)
            {
                for(int i=0;i<17;i++)
                {
                    for(int z=i;z<i+4;z++)
                    {
                         number *= map[z, j];
                    }
                    mulNumber[num] = number;
                    number = 1;
                    num++;
                }
            }
            max = mulNumber[0];
            for(int i=0;i<num;i++)
            {
                if(max <= mulNumber[i])
                {
                    max = mulNumber[i];
                }
            }
            return max;
        }

        public static int Left_Up(int[,] map)
        {
            int i, max = 0, num = 0, number = 1;
            int[] mulNumber = new int[1000];
            for(i = 0;i<17;i++)
            {
                for(int j=0;j<17;j++)
                {
                    for(int z = i; z < i + 4; z++)
                    {
                        number *= map[z, (j + max)];
                        max++;
                    }
                    mulNumber[num] = number;
                    number = 1;
                    num++;
                    max = 0;
                }
            }

            max = mulNumber[0];
            for(i = 0; i < num; i++)
            {
                if (max <=mulNumber[i])
                {
                    max = mulNumber[i];
                }
            }
            return max;
        }

        public static int Right_Up(int[,] map)
        {
            int i, max = 0, num = 0, number = 1;
            int[] mulNumber = new int[1000];
            for (i = 0; i < 17; i++)
            {
                for (int j = 19; j > 2; j--)
                {
                    for (int z = i; z < i + 4; z++)
                    {
                        number *= map[z, (j - max)];
                        max++;
                    }
                    mulNumber[num] = number;
                    number = 1;
                    num++;
                    max = 0;
                }
            }

            max = mulNumber[0];
            for (i = 0; i < num; i++)
            {
                if (max <= mulNumber[i])
                {
                    max = mulNumber[i];
                }
            }
            return max;
        }
    }
}
