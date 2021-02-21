using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   public static class Match
    {
       public static string print(int x, string old_content)
        {
            return old_content + x.ToString();
        }
      static  int add(int x , int y)
        {
            return x + y;
        }
    }
}
