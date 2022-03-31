﻿using System;

namespace MaxOccuring
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ch=new int[255];
            int i = 0, max;
            int ascii;
            Console.Write("\n\nFind maximum occurring character in a string :\n");
            Console.Write("--------------------------------------------------\n");
            Console.Write("Input the string : ");
            String str = Console.ReadLine();
            int l = str.Length;
            for (i = 0; i < 255; i++)
            {
                ch[i] = 0;
            }
            i = 0;
            while(i<l)
            {
                ascii = (int)str[i];
                ch[ascii] += 1;
                i++;
            }
            max = 0;
            for(i=0;i<255;i++)
            {
                if(i!=32)
                {
                    if (ch[i] > ch[max])
                        max = i;
                }
            }
            Console.Write("The Highest frequency of character '{0}' is appearing for number of times : {1} \n\n", (char)max, ch[max]);
        }
    }
}
