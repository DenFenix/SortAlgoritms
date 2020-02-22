using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = {9,6,7,8,4,10,5 };

            //Random ra = new Random();
            //int[] mass = new int[5];
            //for(int i = 0; i< mass.Length;i++)
            //{
            //    mass[i] = ra.Next(0,100);
            //}

            var iSort = new InsertionSort();

            //iSort.Show(mass);
            iSort.Sort(mass);
            //iSort.Show(mass);

            Console.WriteLine();

             mass = new int[]{ 9, 6, 7, 8, 4, 10, 5 };

            MergeSort ms = new MergeSort();
            ms.Sort(mass,0,3);
            ms.Show(mass);

            //for (int i = mass.Length-2;i>=0;i--)
            //{
            //    int key = mass[i];
            //    int j = i + 1;
            //    while(j<mass.Length && key > mass[j])
            //    {
            //        mass[j - 1] = mass[j];
            //        j++;

            //    }
            //    mass[j-1] = key;

            //    iSort.Show(mass);
            //}
            Console.ReadKey();
        }
    }
}
