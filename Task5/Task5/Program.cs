using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(ReadLine());
            int y=Convert.ToInt32(ReadLine());
            int dif = x - y;
           if(x>y)
            {
                WriteLine(dif + dif);
            }
            
        }
 
    }
}
