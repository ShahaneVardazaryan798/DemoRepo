using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(ReadLine());
            int y = Convert.ToInt32(ReadLine());
            int sum = x + y;
             if(x==y)
            {
                WriteLine((sum)*3);
            }
             else
            {
                WriteLine(sum);
            }
        }
    }
}
