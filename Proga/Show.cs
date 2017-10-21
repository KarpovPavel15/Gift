using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga
{
    class Show
    {
        public static void outputinfo(List<Sweet> AllSweet)
        {
            foreach(Sweet swt in AllSweet)
            {
                Console.WriteLine(swt.ToString());
            }
        }
    }
}
