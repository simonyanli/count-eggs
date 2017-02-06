using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggs;
           for (int i=1;i<10;i++)
            {
                 eggs = 63 * (10 * i + 3);
                if (((eggs+1)%5==0)&&((eggs-3)%6==0)&&((eggs-1)%8==0))
                {
                    Console.WriteLine("The minimum number of eggs is {0}", eggs);
                    break;
                }
            }
                
        }
    }
}
