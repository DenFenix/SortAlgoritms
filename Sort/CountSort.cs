using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    //сохраняем количество встреченных чисел исходного массива в соответсвующие числу номера ячеек второго массива
    //затем из второго массива поочередно заполняем первый
    class CountSort : AlgoritmSort

    {
        public override void Sort(int[] mass)
        {
            var min = mass[0]; 
            var max = mass[0];

            foreach (var num in mass)
            {
                if (min > num)
                    min = num;
                if (max < num)
                    max = num;
            }
            CountingSort(mass, min, max);
        }

        private void CountingSort(int[] mass, int min, int max)
        {
            var delta = max - min + 1;
            int[] count = new int[delta];
            //for (int i=0; i<delta;i++)
            //{
            //    count[i] = 0;
            //}
            foreach(int num in mass)
            {
                count[num - min]++;
            }
            int pos = 0;

            for (int i=0; i<delta; i++)
            {
                for(int j=0; j<count[i];j++)
                {
                    mass[pos] = i + min;
                    pos++;
                }
            }

        }
    }
}
