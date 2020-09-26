using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> l = new List<string>() {"Химия","Биология","Алгебра","Геометрия"};
            foreach(string s in l)
            {
                Console.Write(s);
               
            }
            Console.WriteLine(l.Count);
            
            Console.WriteLine(l[0]);
            Console.WriteLine(l[1]);
            Console.WriteLine(l[2]);
            Console.WriteLine(l[3]);

            l.Clear();


            Console.WriteLine("Hello World!");
            Console.Clear();
            
            Console.ReadKey();
        }
    }
}
