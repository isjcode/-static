using System;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    static class Etxension
    {
        public static bool IsEven(this int i)
        {
            return i % 2 == 0;
        }

        public static int[] GetValueIndexes(this int[] int_array, int i)
        {
            int[] ret = { };
            for (int a = 0; a < int_array.Length; a++)
            {
                if (int_array[a] == i)
                {
                   Array.Resize(ref ret, ret.Length + 1);
                   ret[ret.Length - 1] = a;
                }
            }

            return ret;
        }
    }
}