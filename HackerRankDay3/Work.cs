using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankDay3
{
    public class Work
    {
        public static string IsItWeird(int n)
        {
            if (n % 2 != 0)
            {
                return "Weird";
            }
            else
            {
                if (n > 5 && n < 20)
                {
                    return "Weird";
                }

                return "Not Weird";
            }
            //throw new NotImplementedException();
        }
    }
}
