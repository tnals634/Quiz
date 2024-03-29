﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public static partial class Quizes
    {
        public static void Quiz_1()// 1~1000사이의 3과5의 배수 합
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

        public static void Quiz_2()// 400만을 넘지 않는 짝수 피보나치 수열의 합
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

        public static void Quiz_3()// 600851475143의 최대 소인수 구하기
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

        public static void Quiz_4()// 1~20까지의 숫자로 모두 나눠지는 최소의 수
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

        public static void Quiz_5()// 10001번째 소수 구하기
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

        public static void Quiz_6()//격자에서 4가지 수 곱한것 중에 가장 큰 수 
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

        public static void Quiz_7()// 1~1000까지의 영어 단어 수
        {
            string[] number_1 = {"one","two","three","four",
                "five","six","seven","eight","nine" };
            string[] number_2 = { "eleven", "twelve", "thirteen", "fourteen",
                "fifteen", "sixteen", "seventeen","eighteen","nineteen"};
            string[] number_10 = {"twenty", "thirty", "forty", "fifty",
                "sixty", "seventy", "eighty", "ninety" };
            int sum = 0, j = 0, number = 0, number10 = 0, n = 0;
            int[] count = new int[1000];
            for(int i=0;i<1000;i++)
            {
                count[i] = i + 1;
            }
            for (int i = 0; i < 1000; i++)
            {
                if (count[i] < 10)
                {
                    sum += number_1[i].Length;
                    Console.WriteLine($"{number_1[i]}");
                }

                else if (count[i] == 10)
                {
                    sum += "ten".Length;
                    Console.WriteLine("ten");
                    j = i + 1;
                }

                else if (count[i] < 20)
                {
                    sum += number_2[i - j].Length;

                    Console.WriteLine($"{number_2[i - j]}");
                }
                else if ((20 <= count[i]) && (count[i] < 100))
                {
                    if (count[i] % 10 == 0)
                    {
                        number10 = count[i] / 10;
                        sum += number_10[number10-2].Length;
                        Console.WriteLine($"{number_10[number10-2]}");
                    }
                    else
                    {
                        number = (count[i] % 10);
                        sum += number_10[number10-2].Length;
                        sum += number_1[number - 1].Length;
                        Console.Write($"{number_10[number10-2]}");
                        Console.WriteLine(" {0}", number_1[number - 1]);
                    }
                    Console.WriteLine();                    
                }

                else if (count[i] == 100)
                {
                    sum += "onehundred".Length;
                    Console.WriteLine("one hundred");
                }

                else if ((100 < count[i]) && (count[i] < 1000))
                {
                    if (count[i] % 100 == 0)
                    {
                        number = count[i] / 100;
                        sum += number_1[number - 1].Length;
                        sum += "hundred".Length;
                        Console.Write($"{number_1[number - 1]}");
                        Console.WriteLine("hundred");
                    }
                    else
                    {
                        number = count[i] / 100;
                        sum += number_1[number - 1].Length;
                        sum += "hundred".Length;
                        sum += "and".Length;
                        Console.Write($"{number_1[number - 1]}");
                        Console.Write(" hundred and ");
                        n = count[i] - (number * 100);                        
                        if (n < 10)
                        {
                            sum += number_1[n - 1].Length;
                            Console.WriteLine($"{number_1[n - 1]}");
                            
                        }
                        else if(n == 10)
                        {
                            sum += "ten".Length;
                            Console.WriteLine("ten");
                        }
                        else
                        {
                            if (n % 10 == 0)
                            {
                                number10 = n / 10;
                                sum += number_10[number10 - 2].Length;
                                Console.WriteLine($"{number_10[number10 - 2]}");
                            }
                            else
                            {
                                number10 = n / 10;
                                if (number10 == 1)
                                {
                                    number = n - (number10 * 10);
                                    sum += number_2[number - 1].Length;
                                    Console.WriteLine($"{number_2[number - 1]}");
                                }
                                else
                                {
                                    sum += number_10[number10 - 2].Length;
                                    number = n - (number10 * 10);
                                    sum += number_1[number - 1].Length;
                                    Console.Write($"{number_10[number10 - 2]}");
                                    Console.WriteLine($"{number_1[number - 1]}");
                                }
                            }
                        }


                    }
                }
                else if (count[i] == 1000)
                {
                    sum += "onethousand".Length;
                    Console.WriteLine("oneThousand");
                }
            }
            Console.WriteLine($"{sum}");
        }

        public static void Quiz_8()// 1901년 1월1일~2000년 12월31일에서 매월 1일이 일요일인 경우 총 몇번?
        {
            int[] Month_30 = {4,6,9,11 };
            int[] Month_31 = {1,3,5,7,8,10,12 };
            int[,] Days = new int[6, 7];
            int MonthCheck_30 = 0,MonthCheck_31 = 0,m = 1, firstNumber = 1, lastNumber = 0;
            int[] Years = new int[101];
            int yearcheck = 0;
            int sunday = 0;
            for(int i=0;i<101;i++)
            {
                Years[i] = 1900 + i;
            }


            while (yearcheck<101)
            {
                Console.WriteLine($"-----{Years[yearcheck]}년도------");

                while (m < 13)
                {
                    for (MonthCheck_30 = 0; MonthCheck_30 <=3; MonthCheck_30++)
                    {
                        if (m == Month_30[MonthCheck_30])
                        {
                            Console.WriteLine($"========={m}월=========");
                            Console.WriteLine("일 월 화 수 목 금 토");
                            MonthCheck_31 = 0;
                            lastNumber = CalendarLastNumber(Days, Month_30, Month_31, MonthCheck_30, MonthCheck_31, m, firstNumber, Years, yearcheck);
                            CalendarPrint(Days);
                            if(0<yearcheck)
                            {
                                if(Days[0,0]==1)
                                {
                                    sunday++;
                                }
                            }
                            firstNumber = lastNumber + 1;
                            if (6 < firstNumber)
                            {
                                firstNumber = 0;
                            }
                            m++;
                        }
                    }
                    for (MonthCheck_31 = 0; MonthCheck_31 <= 6; MonthCheck_31++)
                    {
                        if (m == Month_31[MonthCheck_31])
                        {
                            Console.WriteLine($"========={m}월=========");
                            Console.WriteLine("일 월 화 수 목 금 토");
                            MonthCheck_30 = 0;
                            lastNumber = CalendarLastNumber(Days, Month_30, Month_31, MonthCheck_30, MonthCheck_31, m, firstNumber, Years, yearcheck);
                            CalendarPrint(Days);
                            if (0 < yearcheck)
                            {
                                if (Days[0, 0] == 1)
                                {
                                    sunday++;
                                }
                            }
                            firstNumber = lastNumber + 1;
                            if (6 < firstNumber)
                            {
                                firstNumber = 0;
                            }
                            m++;
                        }
                    }
                    if (m == 2)
                    {
                        Console.WriteLine($"========={m}월=========");
                        Console.WriteLine("일 월 화 수 목 금 토");
                        MonthCheck_31 = MonthCheck_30 = 0;
                        lastNumber = CalendarLastNumber(Days, Month_30, Month_31, MonthCheck_30, MonthCheck_31, m, firstNumber, Years, yearcheck);
                        CalendarPrint(Days);
                        if (0 < yearcheck)
                        {
                            if (Days[0, 0] == 1)
                            {
                                sunday++;
                            }
                        }
                        firstNumber = lastNumber + 1;
                        if (6 < firstNumber)
                        {
                            firstNumber = 0;
                        }
                        m++;
                    }
                }
                m = 1;
                yearcheck++;
                Console.WriteLine();
            }
            Console.WriteLine("매월 1일 일요일은 총 {0}번이다",sunday);
        }

        public static int CalendarLastNumber(int[,] input, int[] month_30, int[] month_31, int monthCheck_30, int monthCheck_31, int monthNumber, int firstNumber,int[] year, int yearcheck)
        {
            int daysNumber = 0, last = 0;
            int count = 0;
            int[] leap_year = new int[100];
            int leap = 0;
            int c = 0;

            for (int i = 1; i < 2001; i++)
            {
                if (i % 400 != 0)
                {
                    count++;
                }
                if (count == 100)
                {
                    leap_year[leap] = i;
                    leap++;
                    c = 0;
                }
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    input[i, j] = 0;
                }
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = firstNumber; j < 7; j++)
                {
                    if (monthNumber == month_30[monthCheck_30])
                    {
                        if (daysNumber < 30)
                        {
                            daysNumber++;
                            input[i, j] = daysNumber;
                            last = j;
                        }
                    }
                    else if (monthNumber == month_31[monthCheck_31])
                    {
                        if (daysNumber < 31)
                        {
                            daysNumber++;
                            input[i, j] = daysNumber;
                            last = j;
                        }
                    }
                    else if (monthNumber == 2)
                    {
                        if (leap_year[leap - 1] == year[yearcheck])
                        {
                            if (daysNumber < 28)
                            {
                                daysNumber++;
                                input[i, j] = daysNumber;
                                last = j;
                            }
                        }
                        else if (year[yearcheck] % 4 == 0)
                        {
                            if(daysNumber<29)
                            {
                                daysNumber++;
                                input[i, j] = daysNumber;
                                last = j;
                            }
                        }
                        else
                        {
                            if(daysNumber<28)
                            {
                                daysNumber++;
                                input[i, j] = daysNumber;
                                last = j;
                            }
                        }
                    }

                }
                firstNumber = 0;
            }
            daysNumber = 0;

            return last;
        }

        public static void CalendarPrint(int[,] input)
        {
            for(int i=0;i<6;i++)
            {
                for(int j=0;j<7;j++)
                {
                    if(input[i,j]!=0)
                    {
                        if(input[i,j]<10)
                        {
                            Console.Write($" {input[i,j]} ");
                        }
                        else
                        {
                            Console.Write($"{input[i,j]} ");
                        }
                    }
                    else if (input[i, j] == 0)
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void Quiz_9()
        {
            double number = 1;
            int[] count = new int[200];
            int countCheck = 0;
            for (int i = 1; i <= 100; i++)
            {
                number = number * i;
                Console.WriteLine($"{i}");
                Console.WriteLine($"{number}");
            }
            Console.WriteLine($"_{number}_");
            factorial(number, count, countCheck);
        }

        public static void factorial(double num, int[] b, int i)
        {
            if(num>=10)
            {
                b[i] = (int)(num % 10);
                Console.WriteLine($"***{b[i]}***");
                num = num / 10;
                Console.WriteLine($"---{num}---");
                i++;
                factorial(num, b,i);
            }
            else
            {
                b[i] = (int)(num % 10);
                Console.WriteLine($"***{b[i]}***");
                num = num / 10;
                Console.WriteLine($"---{num}---");
                i++;
                Console.WriteLine();
                for (int j = i-1; j >= 0; j--)
                {
                    Console.Write($"{b[j]}, ");
                }
            }

        }
    }
}
