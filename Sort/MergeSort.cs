using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    //делим коллекцию по полам рекурсивно, пока в коллекции не останется 2 элемента
    //разбиваем полученную колецию на 2, сравниваем и собираем обратно по возрастанию, каждую отсортированную коллекцию
    //пока не соберем коллекцию начального размера, но уже полностью отстортированную

        
    public class MergeSort : AlgoritmSort
    {
        public override void Sort(int[] mass)
        {
            Sort(mass, 0, mass.Length-1);
            
        }

        public void Sort(int[] mass, int start, int fin)
        {
            if (start >= fin) return;

            var midle = (fin + start) / 2;
            Sort(mass, start, midle);
            Sort(mass, midle + 1, fin);
            Merge(mass, start, midle, fin);

        }

        protected void Merge(int[] array, int start, int midle, int fin)
        {
            //if (start >= midle || fin < midle || fin < start)
            //    return;

            var left = midle - start + 1;
            var reight = fin - midle;
            var leftArray = new int[left+1];
            var reightArray = new int[reight+1];
            int i, j;
            for (i =0; i<left; i++)
            {
                leftArray[i] = array[start + i];
            }
            for (j = 0; j< reight; j++)
            {
                reightArray[j] = array[midle + j+1];
            }

            leftArray[left] = int.MaxValue;
            reightArray[reight] = int.MaxValue;

            i = 0;
            j = 0;
            for (int k = start; k<=fin;k++)
            {
                if (leftArray[i]<= reightArray[j])
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
