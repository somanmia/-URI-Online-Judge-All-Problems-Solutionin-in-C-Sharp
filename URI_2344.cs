using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2344
{
    class URI
    {
        static void Main(string[] args)
        {
            int num;
           
                num = Convert.ToInt32(Console.ReadLine());
                if (num == 0)
                {
                    Console.WriteLine("E");
                }else if(num>=1 && num <= 35)
                {
                    Console.WriteLine("D");
                }else if(num>=36 && num <= 60)
                {
                    Console.WriteLine("C");
                }else if(num>=61 && num <= 85)
                {
                    Console.WriteLine("B");
                }else if(num>=86 && num <= 100)
                {
                    Console.WriteLine("A");
                }
            Console.ReadKey();
            
        }
    }
}
