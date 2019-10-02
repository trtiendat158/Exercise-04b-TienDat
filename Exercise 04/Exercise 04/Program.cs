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
            int[] arr = new int[5];
            InputInt(arr);
            Console.WriteLine(IsContain5(arr));
            Console.WriteLine(IsContain5_or_6(arr));
            Console.WriteLine(IsContain5_and_6(arr));
            Console.WriteLine(Count5(arr));
            Console.WriteLine(Count5or6(arr));
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
            Console.Write("IsContaint5 is: ");
            for (int i = 0; i < arr.Length; i++ )
            {        
                if (arr[i] == 5)
                    return true;
            }
                return false;
        }

        public static bool IsContain5_or_6(int[] arr)
        {
            Console.Write("IsContains 5 or 6 is: ");
            for (int i = 0; i < arr.Length; i++)
            {   
                if (arr[i] == 5 || arr[i] == 6)
                    return true;
            }
                return false;
        }

        public static bool IsContain5_and_6(int[] arr)
        {
            //Console.Write("Is contains 5 and 6 is: ");
            //bool five = false, six = false;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == 5) five = true;
            //    else if (arr[i]==6) six = true;
            //}
            //if (five && six == true) return true;
            //else return false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5)
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr[j] == 6)
                            return true;
                    }
                }
            }return false;
        }

        public static int Count5(int[] arr)
        {
            int dem = 0;
            for(int i =0; i< arr.Length; i++)
            {
                if (arr[i] == 5)
                    dem++;
            }
            Console.Write("So phan tu 5 xuat hien {0} lan", dem);
            return dem;
        }

        public static int Count5or6(int[]arr)
        {
            int dem = 0;
            for(int i=0; i<arr.Length;i++)
            {
                if (arr[i] == 5)
                {
                    dem++;
                    Console.Write("Phan tu 5 xuat hien {0} lan ", dem);
                }
                else if (arr[i] == 6)
                {
                    dem++;
                    Console.Write("Phan tu 6 xuat hien {1} lan ", dem);
                }
            }
            
            return dem;
        }
    }
}
