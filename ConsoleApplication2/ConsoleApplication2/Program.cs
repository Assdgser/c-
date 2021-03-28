using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Calculate
    {
        public static int JianFa(int x, int y)
        {
            return x - y;
        }
        ///<summary>
        ///两个整数相减
        ///</summary>
        ///<param name="x">第一个减数</param>
        ///<param name="y">第二个减数</param>
        ///<returns></return>
        public static string JianFa(ref string x, ref string y)
        {
            string[] xx; string[] yy; string[] zz;
            xx = new string[100];
            yy = new string[100];
            for (int i = 0; i < x.Length; i++)
            {
                xx[i] = x[i].ToString();
            }
            for (int i = 0; i < y.Length; i++)
            {
                yy[i] = y[i].ToString();
            }
            for (int i = 0; i < y.Length; i++)
            {
                for (int j = 0; j < x.Length;j++)
                {
                    if (xx[j] == yy[i])
                    {
                        for (int k = j; k < x.Length; k++)
                            xx[k] = xx[k + 1];
                        break;
                    }

                }
            }
            string z = string.Join("", xx);
            return z;
        }
        public static int JiaFa(int x, int y)
        {
            return x + y;
        }

        public static string JiaFa(ref string x, ref string y)
        {
            string[] xx; string[] yy; string[] zz;
            xx = new string[100];
            yy = new string[100];
            zz = new string[200];
            for (int i = 0; i < x.Length; i++)
            {
                xx[i] = x[i].ToString();
                zz[i] = xx[i];
            }
            for (int i = 0; i < y.Length; i++)
            {
                yy[i] = y[i].ToString();
                zz[x.Length + i] = yy[i];
            }
            string z = string.Join("", zz);
            return z;
        }
        public static int ChengFa(int x, int y)
        {
            return x * y;
        }

        public static int ChuFa(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine("除数不可为0。");
                return 0;
            }
            else
            return x / y;
        }

    }
    class Program
    {

        public static void Equals(ref int x, ref int y)
        {
            if (x == y)
            {
                Console.WriteLine("{0}与{1}相等。", x, y);
            }
            else
            {
                Console.WriteLine("{0}与{1}不相等。", x, y);
            }
        }
        static void Main(string[] args)
        {
            string x,y;
            int a,b,s=0;

            Console.Write("请输入x的值：");
            x =  Console.ReadLine();
            if (int.TryParse(x, out a))
                s = s + 0;
            else
                s++;
            Console.Write("请输入运算符：");
            char c = Convert.ToChar(Console.ReadLine());

            Console.Write("请输入y的值：");
            y = Console.ReadLine();
            if (int.TryParse(y, out b))
                s = s + 0;
            else
                s++;

            if (s == 0)
            {
                if (c == 43)
                {
                    Console.WriteLine("{0}+{1}={2}", a, b, Calculate.JiaFa(a, b));
                }
                else if (c == 45)
                {
                    Console.WriteLine("{0}-{1}={2}", a, b, Calculate.JianFa(a, b));
                }
                else if (c == 42)
                {
                    Console.WriteLine("{0}*{1}={2}", a, b, Calculate.ChengFa(a, b));
                }
                else if (c == 47)
                {

                    Console.WriteLine("{0}/{1}={2}", a, b, Calculate.ChuFa(a, b));
                }
            }
            else
            {
                if (c == 43)
                {
                    Console.WriteLine("{0}+{1}={2}", x, y, Calculate.JiaFa(ref x, ref y));
                }
                else if (c == 45)
                {
                    Console.WriteLine("{0}-{1}={2}", x, y, Calculate.JianFa(ref x, ref y));
                }
            }


        }
    }
}
