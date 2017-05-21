using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProblemSetD2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Question 1 **");
            Question1(4);
            Console.WriteLine("** Question 2 **");
            Question2(4);
            Console.WriteLine("** Question 3 **");
            Console.WriteLine(Question3(10.0, 2));
            Console.WriteLine("** Question 4 **");
            Console.WriteLine(Question4(10.0, 2));
            Console.WriteLine("** Question 5 **");
            Question5();
            Console.WriteLine("** Question 6 **");
            Console.WriteLine(Question6("Herra"));
            Console.WriteLine("** Question 7 **");
            List<int> l = new List<int>() {1,2,3,4};
            Console.WriteLine(Question7_ite(l));
            Console.WriteLine(Question7_rec(l,l.Count-1));
            Console.WriteLine("** Question 8 **");
            Console.WriteLine(Question8(10));
            Console.WriteLine("** Question 9 **");
            Question9(3,1,3,2);
            Console.WriteLine("** Question 10 **");
            Question10(5);
        }

        static void Question1(int max, int n=0)
        {
            if (n <= max)
            {
                Question1(max, n+1);
                Console.WriteLine(n + " ");
            }
        }

        static void Question2(int n)
        {
            if (n < 0) return;

            Question2(n-1);
            Console.WriteLine(n);
        }

        static double Question3(double x, int n)
        {
            double res = 1.0;

            for (int i = 0; i < n; i++)
            {
                res = res * x;
            }

            return res;
        }

        static double Question4(double x, int n)
        {
            if (n == 0) return 1;
            if (n > 0)
            {
                return x * Question4(x, n - 1);
            }
            if (n < 0)
            {
                return x * Question4(x, n + 1) / x;
            }
            return 1;
        }

        static void Question5()
        {
            #region Speed1
            // Let us make a Stopwatch object
            Stopwatch timer = new Stopwatch();
            // Starting the timer
            timer.Start();
            Question3(10.0, 2);
            // Stopping our timer
            timer.Stop();
            Console.WriteLine("The question3 took {0}ms",
                timer.ElapsedMilliseconds);
            #endregion
            #region Speed2
            // Resetting the timer
            timer.Reset();
            // Starting the timer
            timer.Start();
            Question4(10.0, 2);
            // Stopping our timer
            timer.Stop();
            Console.WriteLine("The question4 took {0}ms",
                timer.ElapsedMilliseconds);
            #endregion
            #region speed3
            // Resetting the timer
            timer.Reset();
            // Starting the timer
            timer.Start();
            double d = Math.Pow(10.0, 2.0);
            Console.WriteLine(d);
            // Stopping our timer
            timer.Stop();
            Console.WriteLine("The Math.pow took {0}ms",
                timer.ElapsedMilliseconds);
            #endregion
        }

        static String Question6(String str)
        {
            if (str.Length <= 1)
                return str;
            else
                return Question6(str.Substring(1)) +str[0];
        }

        static int Question7_ite(List<int> arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }

        static int Question7_rec(List<int> arr, int n)
        {
            int sum = 0;
            if (n < 0)
            {
                return 0;
            }
            else
            {
                return arr[n] + Question7_rec(arr, n - 1);
            }
        }

        static String Question8(int n)
        {
            int remainder;
            string result = string.Empty;
            while (n > 0)
            {
                remainder = n % 2;
                n /= 2;
                result = remainder.ToString() + result;
            }

            return result;
        }

        static void Question9(int n, int from, int to, int other)
        {
            if (n > 0)
            {
                Question9(n - 1, from, other, to);
                Console.WriteLine("Move disk {0} from tower {1} to tower {2}", n, from, to);
                Question9(n - 1, other, to, from);
            }
        }

        static void Question10(int limit)
        {
            if(limit > 1)
            {
                string temp = "";
                for (int i = 0; i <= limit; i++)
                {
                    temp += i.ToString() + " ";
                    Console.WriteLine(temp.Substring(0, i * 2));
                }
                for(int i = limit - 1; i >=0; i--)
                {
                    Console.WriteLine(temp.Substring(0, i * 2));
                }
            }
        }
    }
}