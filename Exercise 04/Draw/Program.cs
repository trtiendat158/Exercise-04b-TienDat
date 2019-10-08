using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool test = true;

            while(test)
            {
                Console.Write("Please input length: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Please input character: ");
                char c = char.Parse(Console.ReadLine());
                Console.WriteLine("Your draw vertical: ");
                DrawVertical(n, c);
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("\nYour draw horizal: ");
                DrawHorizal(n, c);
                Console.WriteLine("\n-----------------------------------------------------------");
                Console.WriteLine("\nYour draw square: ");
                DrawSquare(n, c);
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("\nYour draw square 2: ");
                DrawSquare2(n, c);
                Console.WriteLine("\n-----------------------------------------------------------");
                Console.WriteLine("\nYour draw u: ");
                DrawU(n, c);
                Console.WriteLine("\n-----------------------------------------------------------");
                Console.WriteLine("\nYour draw v: ");
                DrawV(n, c);
                Console.WriteLine("\n-----------------------------------------------------------");
                Console.WriteLine("\nYour draw v 2: ");
                DrawV2(n, c);
                Console.WriteLine("\n-----------------------------------------------------------");
                Console.WriteLine("\nYour draw triangle: ");
                DrawTriangle(n, c);
                Console.WriteLine("\n-----------------------------------------------------------");

                Console.WriteLine("\n Do you want to continue ? Y/N ?");
                string yn = Console.ReadLine();
                if (yn.ToUpper().Equals("Y")) test = true;
                else test = false;
            }
            Console.ReadLine();
        }

        public static void DrawVertical(int n, char c)
        {
            for(int i=0; i<n;i++)
            {
                Console.WriteLine(c);
            }
        }

        public static void DrawHorizal(int n, char c)
        {
            for(int i=0; i<n; i++)
            {
                Console.Write(c);
            }
        }

        public static void DrawSquare(int n, char c)
        {
            for(int i=0; i<n;i++)
            {
                DrawHorizal(n, c);
                Console.WriteLine();
            }
        }

        public static void DrawSquare2(int n, char c)
        {
            DrawHorizal(n,c);               // draw the first horizal line
            Console.WriteLine();            // down the line
            for (int i = 0; i < n - 2; i++) // i<n-2 be able to draw the first and last line DrawHorizal(n,c);
            {    
                DrawHorizal(1, c);          //ve draw 1 left
                DrawHorizal(n -2 , ' ');    // draw space in the middle, if draw n, will ouput DrawHolizal(1,c) + n space + DrawHolizal(1,c)
                DrawHorizal(1, c);          // then draw space in the middle, draw 1 right
                Console.WriteLine();
            }
            DrawHorizal(n, c);              // draw the last horizal line
        }

        public static void DrawU(int n, char c)
        {
            for (int i=0; i<n-1; i++)    // i<n-1 be able to draw the last line DrawHorizal(n,c);
            {
                DrawHorizal(1, c);       //ve draw 1 left
                DrawHorizal(n-2 , ' ');  // draw space in the middle, if draw n, will ouput DrawHolizal(1,c) + n space + DrawHolizal(1,c)
                DrawHorizal(1, c);      // then draw space in the middle, draw 1 right
                Console.WriteLine();    
            }
            DrawHorizal(n, c);           // draw the last horizal line
        }

        public static void DrawV(int n, char c)
        {
            int a = 2*n-3, b = 0;                   // 2*n-3 always output odd number
            for(int i=0; i<n; i++)
            {
                DrawHorizal(b, ' ');                // draw space ahead
                DrawHorizal(1, c);                  // draw 1 character then draw space ahead
                DrawHorizal(a, ' ');                // draw space in the middle
                if (n - 1 > b) DrawHorizal(1, c);   // draw n-1 to draw last character in the middle
                a -= 2;                             // decrease twice
                b++;                                // increase space ahead 
                Console.WriteLine();
            }
        }

        public static void DrawV2(int n, char c)
        {
            DrawHorizal(2 * n -1 , c);
            Console.WriteLine();

            int a = 2 * n - 5, b = 1;                   
            for (int i = 0; i < n-1; i++)
            {
                DrawHorizal(b, ' ');                
                DrawHorizal(1, c);                 
                DrawHorizal(a, ' ');               
                if (n - 1 > b) DrawHorizal(1, c);  
                a -= 2;                            
                b++;                                
                Console.WriteLine();
            }
        }

        public static void DrawTriangle(int n, char c)
        {
            int a = n - 1, b = 0;
            for (int i = 0; i < n - 1; i++)
            {
                DrawHorizal(a, ' ');            // draw n-1 space 
                DrawHorizal(1, c);              // then draw character (vertice of the triangle)
                if (i != 0)                     
                {
                    DrawHorizal(b, ' ');        // there is behind vertice of the triangle
                    DrawHorizal(1, c);
                    b += 2;                     // bonus space in the middle twice in the right, behind DrawHorizal(b, ' ');
                }
                else b++;                       //  because DrawHorizal(b, ' '); at position 0 , should bonus 1 space for it
                a--;                            // decrease ahead
                Console.WriteLine();
            }
            DrawHorizal(2 * n - 1, c);
        }
    }
}
