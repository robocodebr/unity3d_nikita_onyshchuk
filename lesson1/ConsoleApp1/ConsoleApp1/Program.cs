using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            //// int k = 0;
            //// int p =14;

            /* Console.WriteLine($"{x} {y}");
             Console.WriteLine(x +" "+y );
             int[] arr = new int[] { 1, 2, 3, 4, 5 };
            /* float[] arr2;
             arr2 = new float[10];
             for (int i = 0; i < 10; i++)
            */
            /// {
            //////     arr2[i] = i;
            ///}
            ////int j = 0;
            ///// while (j < 10)
            /// {
            ////   Console.WriteLine(arr2[j]);
            /////  j++;
            ///}
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            double[] arr2;
            arr2 = new double[6];
            for (int i = 0; i < 6; i++) {
                arr2[i] = Math.Pow(2,i+1);
            
            }
            int p = 0;
            while (p < 6)
            {
                Console.WriteLine(arr2[p]);
                p++;
            }

           //// Console.WriteLine(k + " " + p);
            
           /// Console.WriteLine("Hello World!");
        
        }
    }
}
