using System;
using System.Diagnostics;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 18, 12, 16, 9, 15 };
            String[] str = { "selection", "merge", "bubble", "quick", "insertion" };
            Console.WriteLine("Alkutilanne: ");
            for (int k = 0; k < number.Length; k++)
            {
                Console.Write("{0}\t",number[k]);
            }
            Console.WriteLine("");
            Console.WriteLine("sorttaukset alkavat: ");
            Console.WriteLine("** 1: START BUBBLESORT **");
            Stopwatch watch = Stopwatch.StartNew();
            MyBubbleSort(number);
            watch.Stop();
            Console.WriteLine("> BubbleSort vei: " + watch.Elapsed.TotalMilliseconds + "ms");
            watch.Reset();
         
            Console.WriteLine("** 2: START INSERTIONSORT **");
            watch.Start();
            MyInsertionSort(number);
            watch.Stop();
            Console.WriteLine("> InsertionSort vei: " + watch.Elapsed.TotalMilliseconds + "ms");
            watch.Reset();
            
            Console.WriteLine("** 3: START SELECTIONSORT **");
            watch.Start();
            MySelectionSort(number);
            watch.Stop();
            Console.WriteLine("> SelectionSort vei: " + watch.Elapsed.TotalMilliseconds + "ms");
            
            watch.Reset();
            Console.WriteLine("** 6: START STRING SELECTIONSORT **");
            watch.Start();
            StringSelectionSort(str);
            watch.Stop();
            Console.WriteLine("> SelectionSort vei: " + watch.Elapsed.TotalMilliseconds + "ms");
        }

        // question 1:
        static void MyBubbleSort(int[] number)
        {
            bool flag = true;
            int temp;
            int numLength = number.Length;
            //sorting an array
            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    
                    if (number[j + 1] < number[j])
                    {
                        Console.WriteLine(number[j + 1] + " on pienempi kuin " +number[j]);
                        temp = number[j];
                        Console.WriteLine("Temp-muuttujaan suurempi {0}", temp);
                        number[j] = number[j + 1];
                        Console.WriteLine("Siirretään pienempi taulukossa eteenpäin {0}", number[j]);
                        number[j + 1] = temp;
                        Console.WriteLine("suurempi alkio pienemmän paikalle {0}",temp);
                        flag = true;
                    }
                }
            }
            //Sorted array
            Console.WriteLine("Lopputilanne: ");
            foreach (int num in number)
            {
                Console.Write("{0}\t",num);
            }
            Console.WriteLine("\n** END BUBBLESORT **");
        }

        // question 2:
        static void MyInsertionSort(int[] inputArray)
        {
                for (int i = 0; i < inputArray.Length-1; i++)
                {
                    for (int j = i + 1; j > 0; j--)
                    {
                        Console.WriteLine("alkio {0}", inputArray[j]);
                        if (inputArray[j-1] > inputArray[j])
                        {
                            
                            int temp = inputArray[j-1];
                            inputArray[j-1] = inputArray[j];
                            inputArray[j] = temp;
                        }
                    }
                    Console.WriteLine("pienin {0}", inputArray[i]);
                }
                //Sorted array
                Console.WriteLine("Lopputilanne: ");
                foreach (int num in inputArray)
                {
                    Console.Write("{0}\t",num);
                }
                Console.WriteLine("\n** END INSERTIONSORT **");
        }
        
        // question 3:
        static void MySelectionSort(int[] arr)
        {
            int n=arr.Length;
            for(int x=0; x<n; x++)
            {
                int min_index=x;
                for(int y=x; y<n; y++)
                {
                    Console.WriteLine("alkio {0}", arr[y]);
                    if(arr[min_index]>arr[y])
                    {
                        min_index=y;
                    }
                }
                int temp=arr[x];
                arr[x]=arr[min_index];
                arr[min_index]=temp;
                Console.WriteLine("Vaihdetaan pienimmäksi {0}", temp);
            }
            
            //Sorted array
            Console.WriteLine("Lopputilanne: ");
            foreach (int num in arr)
            {
                Console.Write("{0}\t",num);
            }
            Console.WriteLine("\n** END SELECTIONSORT **");
        }
        
        // question 6:
        static void StringSelectionSort<A>(A[] arr) where A : IComparable
        {
            //pos_min is short for position of min
            int pos_min;
            A temp;

            for (int i=0; i < arr.Length-1; i++)
            {
                pos_min = i; //set pos_min to the current index of array

                for (int j=i+1; j < arr.Length; j++)
                {
                    // CompareTo
                    if (arr[j].CompareTo(arr[pos_min]) < 0)
                    {
                        Console.WriteLine("{0} on aikaisemmin kuin {1}", arr[j], arr[pos_min]);
                        //pos_min will keep track of the index that min is in, this is needed when a swap happens
                        pos_min = j;
                        Console.WriteLine("siirretään aikaisemman osoitin taulukon paikkaan: {0}", j);
                    }                                          
                }

                //if pos_min no longer equals i than a smaller value must have been found, so a swap must occur
                if (pos_min != i)
                {
                    temp = arr[i];
                    arr[i] = arr[pos_min];
                    arr[pos_min] = temp;
                }
      
            }
            //Sorted array
            Console.WriteLine("Lopputilanne: ");
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write("{0}\t",arr[j]);
            }
            Console.WriteLine("\n** END STRING SELECTIONSORT **");
        }

    }
}
