using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(ReadLine());
            if(x>20&&x<100)
            {
                WriteLine(true);

            }
            else
            {
                WriteLine(false);
            }
        }
    }
}
