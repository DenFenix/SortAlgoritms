using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    // на каждом проходе внешнего цикла определяет наименьшее число от текущего до конца(т.е. получается возратсение чисел при смещении на след. позицию
    //во внутреннем цикле если нашлось число меньшее чем откуда начинается внешний цикл, то меняются местами
    class BubleSort : AlgoritmSort
    {
        public override void Sort(int[] mass)
        {
            for (int i=0; i<=mass.Length-1;i++)
            {
                for(int j= mass.Length-1; j>=i+1;j--)
                {
                    if(mass[j]<mass[i])
                    {
                        int key = mass[j];
                        mass[j] = mass[i];
                        mass[i] = key;
                    }                
                }
                Show(mass);
            }
        }
    }
}
