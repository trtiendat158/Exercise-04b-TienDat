using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_04
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            InputInt(arr);
            Console.WriteLine(IsContain5(arr));
        }

        public static void InputInt(int[]arr)
        {
            for(int i=0; i < arr.Length; i++)
            {
                Console.Write("A[{0}] = ", i);
                string str = Console.ReadLine();
                arr[i] = int.Parse(str);
            }
        }

        public static bool IsContain5(int[]arr)
        {
            for (int i = 0; i < arr.Length; i++ )
            {
                if (arr[i] == 5)
                    return true;
            }
                return false;
        }

        public static bool IsContain5_or_6(int[] arr)
        {
            return false;
        }

        public static bool IsContain5_and_6(int[] arr)
        {
            return false;
        }
    }
}
