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
            List<int> lst = new List<int> { 1, 4, 6, 8, 10, 15, 25, 28, 35, 42, 44, 46, 50 };

            Console.WriteLine(BinarySearch(lst,55));

            Insert(lst,5);
            Insert(lst, 15);
            Insert(lst, 55);
            Insert(lst, 27);
            Insert(lst, 10);
            Insert(lst, 38);
        }

        private static int BinarySearch(List<int> lst, int value)
        {
            int l = 0;
            int r = lst.Count-1;

            while(l <= r)
            {
                int mid = (l + r) /2;
                

                if(lst[mid] > value)
                {
                    r = mid - 1;
                }
                else if (lst[mid] < value)
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

        //INSERT ELEMENT TO THAT ARRAY USING BINARY SEARCH
        private static void Insert(List<int> lst, int value)
        {
            int l = 0;
            int r = lst.Count-1;

            bool found = false;

            while (l <= r)
            {
                int mid = (l + r) / 2;

                if (lst[mid] > value)
                {
                    r = mid - 1;
                }
                else if (lst[mid] < value)
                {
                    l = mid + 1;
                }
                else
                {
                    found = true;
                    break;
                }
            }


            if (!found)
            {
                lst.Insert(l, value);
                Console.WriteLine(string.Join(" ",lst));
            }
            else
            {
                Console.WriteLine("exist");
            }
        }
    }
}
