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
            Count5(arr);
            Console.WriteLine(Count5or6(arr));
            Console.WriteLine(SumAll(arr));
            Drawi(arr);
            DrawO(arr);
            DrawO2(arr);
            DrawU(arr);
            DrawV(arr);
            DrawV2(arr);
        }

        public static void InputInt(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("A[{0}] = ", i);
                string str = Console.ReadLine();
                arr[i] = int.Parse(str);
            }
        }

        public static bool IsContain5(int[] arr)
        {
            Console.Write("IsContaint5 is: ");
            for (int i = 0; i < arr.Length; i++)
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
            Console.Write("Is contains 5 and 6 is: ");
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
            } return false;
        }

        public static void Count5(int[] arr)
        {
            int dem = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5)
                    dem++;
            }
            Console.WriteLine("So phan tu 5 xuat hien {0} lan", dem);
        }

        public static int Count5or6(int[] arr)
        {
            int dem = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5 || arr[i] == 6)
                    dem++;
            }
            Console.Write("So lan xuat hien cua 5 hoac 6 la: ", dem);
            return dem;
        }

        public static int SumAll(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.Write("Tong la: ", sum);
            return sum;
        }

        public static void Drawi(int[] arr)
        {
            Console.WriteLine("Draw i :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("i");
            }
        }

        public static void DrawO(int[] arr)
        {
            Console.WriteLine("Draw O: ");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.Write("O");
                }
                Console.WriteLine();
            }
        }

        public static void DrawO2(int[] arr)
        {
            Console.WriteLine("Draw O2:");
            for (int i = 0; i < arr.Length; i++)
            {
               for(int j=0; j<arr.Length; j++)
               {
                   if (i == 0 || i == arr.Length - 1)
                   {
                       Console.Write("o");
                   }
                   else if (j == 0 || j == arr.Length - 1)
                   {
                       Console.Write("o");
                   }
                   else Console.Write(" ");
               }
               Console.WriteLine();
            }
        }

        public static void DrawU(int[]arr)
        {
            Console.WriteLine("Draw U:");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i == arr.Length - 1)
                    {
                        Console.Write("u");
                    }
                    else if (j == 0 || j == arr.Length - 1)
                    {
                        Console.Write("u");
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public static void DrawV(int[]arr)
        {
            Console.WriteLine("Draw V: ");
            int a = arr.Length - 2;
            for(int i =0; i<arr.Length;i++)
            {
                for(int j=0; j<arr.Length;j++)
                {
                    if (i == j)
                    {
                        Console.Write("v");
                    }
                    else Console.Write(" ");
                }
                for (int b = 0; b <= a; b++)
                {
                    if (b == a)
                    {
                        Console.Write("v");
                    }
                    else Console.Write(" ");
                }
                a--;
                Console.WriteLine();
            }
            
        }


        public static void DrawV2(int[]arr)
        {
            Console.WriteLine("Draw V2: ");
            int a = arr.Length - 2;
            int q = 0;
            
            while (q < 2 * arr.Length - 1)
            {
                Console.Write("v");
                q++;
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i == j || i==arr.Length-1)
                    {
                        Console.Write("v");
                    }
                    else Console.Write(" ");
                }
                for (int b = 0; b <= a; b++)
                {
                    if (b == a)
                    {
                        Console.Write("v");
                    }
                    else Console.Write(" ");
                }
                a--;
                Console.WriteLine();
            }
        }

        
    }
}
