using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeView
{
    /// <summary>
    /// 问题:从一组[排序过]的有重复数组中删除[重复]元素
    /// 解决:
    /// 给出了一个较为简便的的二指针法解决方案
    /// 第一个指针用来指向处理好后的空间，第二指针用来指向
    /// 步进的空间,因为原题有空间O(1)限制。
    /// 放宽限制,假设原题没有O(1)限制,可以引入新数组解决,
    /// 那这个问题比较简单,也就是对于空间O(1)限制,一般的解决
    /// 方案都可以参照二指针法，得到空间上的便利!
    /// </summary>
    class SortDuplicateSolution
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="n">元数组长度</param>
        /// <returns>处理后数组长度</returns>
        public int RemoveDuplicate(int[] array,int n)
        {
            if (n == 0) return 0;
            int index = 0;
            for (int i = 1; i < n; i++) {
                if (array[index] != array[i])//array[index]->无重复元素
                {
                    array[++index] = array[i];
                }
            }
            return index + 1;
        }

        /// <summary>
        /// 问题:数组中允许有m个相同(把原题的2扩展到了m)
        /// 解决:
        /// 对上面一题的一个扩展,上面一题是其特殊情况,我考虑的是在
        /// 用数重复的方法来做的,即加上一个计数就可以了
        /// </summary>
        /// <param name="array"></param>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public int RemoveDuplicate2(int[] array,int n,int m)
        {
            if (n == 0) return 0;
            int index = 0;
            int newSeed = 0;
            for (int i = 1; i < n; i++)
            {
                if (array[index] != array[i])
                {
                    newSeed = 0;//开始重新计数
                    array[++index] = array[i];
                }
                else if(newSeed < m-1)
                {
                    array[++index] = array[i];
                    newSeed++;//一样就累计计数
                }
            }
            return index + 1;
        }
    }
}
