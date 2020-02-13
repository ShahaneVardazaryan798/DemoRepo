using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
   class Program
   {
        static void Main(string[] args)
        {
            int i;
            int x;
            i = Convert.ToInt32(ReadLine());
            x = Convert.ToInt32(ReadLine());
          if((i>0 && x<0)||(i<0 && x>0))
          {
               WriteLine( true); 
          }

        }

      
   }
}
