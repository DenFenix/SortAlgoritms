using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//реализовать шаблон стратегия
namespace Sort
{
    abstract class AlgoritmSort
    {
        abstract public void Sort(int[]  mass);

        public void Show(int[] mass)
        {
            foreach (var num in mass)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

    }
}
