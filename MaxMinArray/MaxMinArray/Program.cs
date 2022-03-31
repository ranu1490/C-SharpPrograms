using System;

namespace MaxMinArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nFind maximum and minimum element in an array: ");
            Console.WriteLine("\n-------------------------------------------------- ");

            Console.WriteLine("Input the number of elements to be stored in the array :");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] val = new int[n];
            Console.Write("Input {0} elements in the array :\n", n);
            
            for (int i=0;i<n;i++)
            {
                Console.Write("Element - {0} : ", i);
                val[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = val[0];
            int max = val[0];
            for(int i=0;i<n;i++)
            {
                if(min>val[i])
                {
                    min = val[i];
                }
                if(max<val[i])
                {
                    max = val[i];
                }
            }
            Console.WriteLine("Maximum element is : {0}\n ",max);
            Console.WriteLine("Minimum element is : {0}\n",min);
        }
    }
}
