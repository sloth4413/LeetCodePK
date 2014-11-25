using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeView
{
    class Program
    {
        static void Main(string[] args)
        {
            SortDuplicateSolution   sortDuplicateSolution = new SortDuplicateSolution();

            var array = new[] {1, 2, 2, 2, 3, 4, 5, 6, 6, 6, 6, 6, 7, 8, 9};
            var length = sortDuplicateSolution.RemoveDuplicate2(array,15,4);
            DisplayArray(array,length);
            Console.ReadKey();
        }

        static void DisplayArray(int[] array,int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(array[i].ToString() + ",");
            }
        }
    }
}
