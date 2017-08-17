using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace ProblemD1
{
    class Problems
    {
        public static Random rnd;

        static void Main(string[] args)
        {
            rnd = new Random();
            Problems p = new Problems();
            p.ProblemSetD1_1();
            p.ProblemSetD1_2();
            p.ProblemSetD1_3();
        }

        private void printArray(string[] param, int kerta)
        {
            if (kerta == 0)
            {
                Console.Write("Aloitustilanne ");
            }
            else
            {
                Console.Write("{0}. siirto      ", kerta);
            }

            for (int i = 0; i < param.Length; i++)
            {
                Console.Write("[" + param[i] + "]");

            }
            Console.WriteLine("");
        }

        public void ProblemSetD1_1()
        {
            string[] alkiot = new string[5]{ " (s1) ", " (s2) ", " ( ) ", " (p1) ", " (p2) " };
            Boolean moving = true;
            int aloitus = 0;
            int n = 0;
            string empty = " ( ) ";

            // perustilanne
            printArray(alkiot, 0);

            // siirrot

            alkiot[2] = alkiot[1];
            alkiot[1] = empty;
            printArray(alkiot, 1);

            alkiot[1] = alkiot[3];
            alkiot[3] = empty;
            printArray(alkiot, 2);

            alkiot[3] = alkiot[4];
            alkiot[4] = empty;
            printArray(alkiot, 3);

            alkiot[4] = alkiot[2];
            alkiot[2] = empty;
            printArray(alkiot, 4);

            alkiot[2] = alkiot[0];
            alkiot[0] = empty;
            printArray(alkiot, 5);

            alkiot[0] = alkiot[1];
            alkiot[1] = empty;
            printArray(alkiot, 6);

            alkiot[1] = alkiot[3];
            alkiot[3] = empty;
            printArray(alkiot, 7);

            alkiot[3] = alkiot[2];
            alkiot[2] = empty;
            printArray(alkiot, 8);
        }

        public void ProblemSetD1_2()
        {
            List<int> lst1 = generateListOfNumbers(10);
            
            Console.WriteLine("Isoin ei järjestetty lista {0}", getMax(lst1));

            List<int> lst2 = generateListOfNumbers(10);
            lst2.Sort();

            Console.WriteLine("list sort");
            for (int i = 0; i < lst2.Count; i++)
            {
                Console.WriteLine(lst2[i]);
            }
            Console.WriteLine("Middle number järjestetty {0}", GetMiddleNumber(lst2));
        }

        static int getMax(List<int> lst)
        {
            // find max
            int maxInList = -1;
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i] > maxInList)
                {
                    maxInList = lst[i];
                }
            }
            return maxInList;
        }

        private List<int> generateListOfNumbers(int size)
        {
            List<int> listOfNumbers = new List<int>();



            for (int i = 0; i < size; i++)
            {
                int alkio = rnd.Next(100);
                listOfNumbers.Add(alkio);
                Console.WriteLine(alkio);
            }
            return listOfNumbers;
        }

        private int GetMiddleNumber(List<int> ia)
        {
            // if length is odd, return middle numer
            if (ia.Count % 2 == 1) return ia[ia.Count/2];

            // if length is even return the first of the two middle numbers
            return ia[ia.Count/2  - 1];
        }

        public void ProblemSetD1_3()
        {
            // the number is:
            int correctNumber = rnd.Next(100000);
            int arvaus = -1;
            Console.WriteLine("Voittonumero= {0}", correctNumber);
            Console.WriteLine("Voit arvata mitä numeroa ajattelen (1-100000) 20 kertaa.");
            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine("Anna {0} numero:", i);
                arvaus = Convert.ToInt32(Console.ReadLine());
                if (arvaus == correctNumber)
                {
                    Console.WriteLine("YES");
                    break;
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            
        }
    }
}