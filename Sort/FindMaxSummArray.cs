using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class FindMaxSummArray
    {
        private int[] FindMaxCrossingSubarray(int[] mass, int low, int mid, int high/*, out int maxLeft, out int maxRight, out int leftSum, out int reightSum*/)
        {
            int maxLeft = 0;
            int maxRight = 0;
            int leftSum = int.MinValue;
            int sum = 0;
            for (int i = mid; i>=low;i--)
            {
                sum = sum + mass[i];
                if (sum > leftSum)
                {
                    leftSum = sum;
                    maxLeft = i;
                }                  
            }
            int reightSum = int.MinValue;
            sum = 0;
            for(int j = mid+1; j<= high;j++)
            {
                sum = sum + mass[j];
                if(sum>reightSum)
                {
                    reightSum = sum;
                    maxRight = j;
                }
            }
            return new int[] { maxLeft, maxRight, leftSum + reightSum };
        }
        public int[] FindmaximumSubarray(int[] mass, int low, int height)
        {
            //int[] res /*= new int[3]*/;
            if (height == low)
            {
                //res = new int[3] { low, height, mass[low] };
                return new int[3] { low, height, mass[low] };
            }
            else
            {
                int mid = (low + height) / 2;
                int[] left = FindmaximumSubarray(mass, low, mid);
                int[] reight = FindmaximumSubarray(mass, mid + 1, height);
                int[] cross = FindMaxCrossingSubarray(mass, low, mid, height);
                if (left[2] >= reight[2] && left[2] >= cross[2])
                    return left;
                else if (reight[2] >= left[2] && reight[2] > cross[2])
                    return reight;
                else
                    return cross;
            }
                
        }
    }
}
