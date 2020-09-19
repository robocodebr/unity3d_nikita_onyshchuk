using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            float var1 = 3.14f;
            double var2 = 7.678;
            short var3 = 1;
            byte bt = 12;
            short sht = 13;
            long l = 12l;
            string day = "bbhh";
            switch (day) 
            {
                

                case "M":
                    Console.Write("Monday");
                    break;
                case "T":
                    Console.Write("Tuesday");
                    break;
                case "W":
                    Console.Write("Wednesday");
                    break;
                case "Th":
                    Console.Write("Thursday");
                    break;
                case "F":
                    Console.Write("Friday");
                    break;
                case "Sa":
                    Console.Write("Saturday");
                    break;
                default:
                    Console.Write("not a day");
                    break;

            }


            if(bt > sht)
            {
                Console.WriteLine(bt);
            }
            else if(bt>= l )
            {
                Console.WriteLine(bt);
            }
            else
            {

            }
            
            Console.WriteLine("Hello World!");
        
            if(var1 > var2 && var2 > var1)
            {
                Console.WriteLine(var2);
            }
            else if(var2>var3 && var2> var1)
            {
                Console.WriteLine(var2);
            } else
            {
                Console.WriteLine(var3);

            }


         
        
        }
    }
}
