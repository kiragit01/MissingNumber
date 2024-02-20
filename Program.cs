using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 2 };
            Console.WriteLine(MissingNumber(nums));
            Console.ReadKey();
        }
        
        //O(n log n)
        static int MissingNumber(int[] nums)
        {
            int n = nums.Length;
            Array.Sort(nums);
            for (int i = 0; i < n; i++)
            {
                if (i != nums[i]) return i;
            }
            return n;
        }

        //O(n^2)
        static int MissingNumber_Bad(int[] nums)
        {
            int n = nums.Length;
            int f = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == nums[j])
                    {
                        f = 1;
                        break;
                    }
                    if (f == 0 && j == n - 1) return i;
                }
                f = 0;
            }
            return f;
        }

    }
}
