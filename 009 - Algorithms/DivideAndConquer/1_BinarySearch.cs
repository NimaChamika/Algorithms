using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009___Algorithms.DivideAndConquer
{
    class _1_BinarySearch
    {
        internal static void Solution()
        {
            int[] arr = new int[] { 1, 4, 6, 8, 10, 15, 25, 28, 35, 42, 44, 46, 50 };
            Console.WriteLine(BinarySearch(arr,11));
        }

        private static int BinarySearch(int[] array,int value)
        {
            int l = 0;
            int h = array.Length;

            while(l <= h)
            {
                int mid = (l + h) /2;

                if(array[mid] > value)
                {
                    h = mid - 1;
                }
                else if (array[mid] < value)
                {
                    l = mid + 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }
    }
}
