using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    //пробую объединить алгоритмы
    class MergerInsertionSort:AlgoritmSort
    {

        public override void Sort(int[] mass)
        {
            MergeSort(mass, 0, mass.Length - 1);
            //InsertionSort(mass);
        }

        public void InsertionSort(int[] mass, int start, int fin)
        {
            for (int i = start; i< fin+1; i++)
            {
                int key = mass[i];
                int j = i - 1;
                while(j >= start && mass[j] > key)
                {
                    mass[j + 1] = mass[j];
                    j--;
                }
                mass[j + 1] = key;
            }
        }

        public void MergeSort (int[] mass, int start, int fin)
        {
            //if (start >= fin) return;
            if (fin - start <= 10)
            {
                InsertionSort(mass, start, fin);
                return;
            }
                

            var midle = (start + fin) / 2;

            MergeSort(mass, start, midle);
            MergeSort(mass, midle+1, fin);
            Merge(mass, start, midle, fin);
        }

        private void Merge(int[] array, int start, int midle, int fin)
        {
            var leftLength = midle - start + 1;
            var reightLength = fin - midle;
            var leftArray = new int[leftLength+1];
            var reightArray = new int[reightLength+1];

            int i, j;

            for (i=0;i< leftLength;i++)
            {
                leftArray[i] = array[start + i];
            }

            for (j=0;j<reightLength;j++)
            {
                reightArray[j] = array[midle + j+1];
            }

            leftArray[leftLength] = int.MaxValue;
            reightArray[reightLength] = int.MaxValue;

            i = 0;
            j = 0;
            
            for (int k = start; k<=fin; k++)
            {
                if (leftArray[i] < reightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;
                }                  
                else
                {
                    array[k] = reightArray[j];
                    j++;
                }                    
            }
        }
    }
}
