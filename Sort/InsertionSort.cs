using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{//сортировака вставкой
    //сраниваем nый элемент коллекции(ключ) с каждым предыдущим предыдщими,
    // при этом пока ключ меньше чем сраниваемое число, число сдвигается на ячейку в лево
    //как только число оказывается меньше нашего ключа, то в след ячейку за ним записывается ключ
    class InsertionSort : AlgoritmSort
    {
        public override void Sort(int[] mass)
        {
            for (int j = 1; j < mass.Length; j++)
            {
                int key = mass[j];
                int i = j - 1;
                while (i >= 0 && mass[i] > key)
                {
                    mass[i + 1] = mass[i];
                    i--;
                }
                mass[i + 1] = key;

                Show(mass);
            }
        }
        /*
         * for (int i = mass.Length-2;i>=0;i--)
            {
                int key = mass[i];
                int j = i + 1;
                while(j<mass.Length && key > mass[j])
                {
                    mass[j - 1] = mass[j];
                    j++;
                    
                }
                mass[j-1] = key;

                iSort.Show(mass);
            }
         */
    }
}
