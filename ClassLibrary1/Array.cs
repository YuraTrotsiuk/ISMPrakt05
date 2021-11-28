using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLibrary
{
    public class Array
    {
        public static void FillArrayByRandomValue(int[]a,int minRandomValue=-10,int maxRandomValue=11)
        {
            
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(minRandomValue, maxRandomValue);
            }
        }
        
        
        public static long SumNegElement(int[] a)
        {
            long sumNeg = 0;
            for (int i = 0; i < a.Length; ++i)
            {
                if (a[i] < 0)
                {
                    sumNeg += a[i];
                }
            }
            return sumNeg;
        }
        public static int MaxEvenElement(int[] a)
        {
            int maxEven = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > maxEven && i % 2 == 0)
                {
                    maxEven = a[i];
                }
            }
            return maxEven;
        }
        public static long DobElementEvenIndex(int[] a)
        {
            long dobEvenElement = 1;
            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0)
                {
                    dobEvenElement *= a[i];
                }
            }
            return dobEvenElement;
        }
        public static int IndexMaxElement(int[] a)
        {
            int maxElement = a[0], index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > maxElement)
                {
                    maxElement = a[i];
                    index = i;
                }
            }
            return index; ;
        }
        public static int MaxAbsElement(int[] a)
        {
            int maxAbs = a[0];
            for (int i = 0; i < a.Length; i++)
                if (Math.Abs(maxAbs) < Math.Abs(a[i]))
                {
                    maxAbs = a[i];
                }
            return maxAbs;
        }
        public static int SumIndexPositiveElement(int[] a)
        {
            int sumIndex = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    sumIndex += i;
                }
            }
            return sumIndex;
        }
        public static int NUnpairedElement(int[] a)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
                if (a[i] % 2 != 0)
                {
                    ++count;
                }
            return count;
        }
    }
}
